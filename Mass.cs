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

namespace ImpulseRocketry.Units;

/// <summary>
///
/// </summary>
public sealed class Mass : ScalarUnit {
    /// <summary>
    ///
    /// </summary>
    public static readonly Mass Kg = new("kg", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Mass G = new("g", 0.001);
    
    /// <summary>
    /// 
    /// </summary>
    public static readonly Mass Lb = new("lb", 0.45359237);
    
    /// <summary>
    /// 
    /// </summary>
    public static readonly Mass Oz = new("oz", 0.028349523125);

    private Mass(string name, double factor) : base (name, factor) {
    }

    /// <summary>
    /// Creates a mass value with the specified value and this unit
    /// </summary>
    public MassValue Value(double value) {
        return new MassValue(value, this);
    }
}

/// <summary>
///
/// </summary>
public class MassValue : UnitValue<Mass> {
    /// <summary>
    /// Initialises a new instance of an <see ref="MassValue"/>
    /// </summary>
    public MassValue(double value, Mass unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator MassValue(double value) {
        return Mass.Kg.Value(value);
    }
}