// Copyright 2022 Ben Voß
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files
// (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

namespace ImpulseRocketry.Units;

/// <summary>
/// </summary>
[Generator]
public class GenerateUnitValueSourceGenerator : ISourceGenerator {

    private const string AttributeText = @"
using System;
namespace ImpulseRocketry.Units
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class GenerateUnitValueAttribute : Attribute
    {
        public GenerateUnitValueAttribute()
        {
        }
    }
}";

    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
    }

    public void Execute(GeneratorExecutionContext context)
    {
        context.AddSource("GenerateUnitValueAttribute", SourceText.From(AttributeText, Encoding.UTF8));

        if (context.SyntaxReceiver is not SyntaxReceiver receiver) {
            return;
        }

        var options = (context.Compilation as CSharpCompilation)!.SyntaxTrees[0].Options as CSharpParseOptions;
        var attributeSyntaxTree = CSharpSyntaxTree.ParseText(SourceText.From(AttributeText, Encoding.UTF8), options);
        var compilation = context.Compilation.AddSyntaxTrees(attributeSyntaxTree);
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(@"
namespace ImpulseRocketry.Units;
");
        // Get all the classes with the GenerateUnitValueAttribute
        var attributeSymbol = compilation.GetTypeByMetadataName("ImpulseRocketry.Units.GenerateUnitValueAttribute");
        foreach (var candidateClass in receiver.CandidateClasses) {
            var model = compilation.GetSemanticModel(candidateClass.SyntaxTree);
            if (model.GetDeclaredSymbol(candidateClass) is ITypeSymbol typeSymbol &&
                typeSymbol.GetAttributes().Any(x =>
                    x.AttributeClass.Equals(attributeSymbol, SymbolEqualityComparer.Default))) {
                stringBuilder.Append(@$"
/// <summary>
///
/// </summary>                
public partial class {candidateClass.Identifier.Text} : UnitValue<{candidateClass.Identifier.Text}Unit> {{
    /// <summary>
    /// Initialises a new instance of an <see ref=""{candidateClass.Identifier.Text}Value""/>
    /// </summary>
    public {candidateClass.Identifier.Text}(double value, {candidateClass.Identifier.Text}Unit unit) : base(value, unit) {{
    }}

    /// <summary>
    /// Implicitly converts a double to an acceleration value represented in m/sec2
    /// </summary>
    public static implicit operator {candidateClass.Identifier.Text}(double value) {{
        return {candidateClass.Identifier.Text}.{typeSymbol.GetMembers().First(m => m.IsStatic && m.DeclaredAccessibility == Accessibility.Public).Name}.Value(value);
    }}

    /// <summary>
    ///
    /// </summary>
    public override Conversion In {{
        get {{
            return new Conversion(this);
        }}
    }}

    /// <summary>
    ///
    /// </summary>
    public class Conversion : Conversion<{candidateClass.Identifier.Text}Unit> {{
        internal Conversion({candidateClass.Identifier.Text} value) : base(value) {{
        }}
");

                foreach (var member in typeSymbol.GetMembers().Where(m => m.IsStatic && m.DeclaredAccessibility == Accessibility.Public)) {
                    stringBuilder.Append(@$"
        /// <summary>
        ///
        /// </summary>
        public double {member.Name} {{
            get {{
                return this[{candidateClass.Identifier.Text}.{member.Name}];
            }}
        }}
                    ");
                }

                stringBuilder.Append(@$"
    }}
}}
");
                if (candidateClass.Identifier.Text != "Temperature") {
                    stringBuilder.Append(@$"
/// <summary>
///
/// </summary>
public class {candidateClass.Identifier.Text}Unit : ScalarUnit {{
    internal {candidateClass.Identifier.Text}Unit(string name, double factor) : base (name, factor) {{
    }}
    
    /// <summary>
    /// Creates a {candidateClass.Identifier.Text.ToLower()} value with the specified value and this unit
    /// </summary>
    public {candidateClass.Identifier.Text} Value(double value) {{
        return new {candidateClass.Identifier.Text}(value, this);
    }}
}}
");
                }
            }
        }
            
        context.AddSource("GeneratedUnitValue", SourceText.From(stringBuilder.ToString(), Encoding.UTF8));
    }
}