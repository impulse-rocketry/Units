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

using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ImpulseRocketry.Units.Json;

/// <summary>
/// A <see ref="JsonConverter"/> for <see ref="Unit"/> types.
/// </summary>
public class UnitJsonConverter<T> : JsonConverter<T> where T : Unit {
    private static readonly Dictionary<string, T> NameToValueMap = typeof(UnitValue<>)
            .Assembly
            .GetTypes()
            .Where(t => t.IsAssignableTo(typeof(UnitValue<T>)))
            .First()
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(T))
            .Select(f => (T)f!.GetValue(null)!)
            .ToDictionary(x => x.Name);

    /// <summary>
    /// Reads a JSON string value and returns its represenetation as a <see ref="Unit"/>
    /// </summary>        
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        var unitString = reader.GetString()!;

        return NameToValueMap.TryGetValue(unitString, out var value)
            ? value
            : throw new ApplicationException($"Unable to parse unit {unitString}");
    }

    /// <summary>
    /// Writes a <see ref="Unit"/> as a JSON string value.
    /// </summary>
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) {
        writer.WriteStringValue(value.Name);
    }
}