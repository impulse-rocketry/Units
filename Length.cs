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
public sealed class Length : ScalarUnit {
    /// <summary>
    ///
    /// </summary>
    public static readonly Length Km = new("km", 1000);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Length M = new("m", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Length Cm = new("cm", 0.1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Length Mm = new("mm", 0.001);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Length In = new("in", 0.0254);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Length Ft = new("ft", 0.3048);

    private Length(string name, double factor) : base (name, factor) {
    }

    /// <summary>
    /// Creates a length value with the specified value and this unit
    /// </summary>
    public LengthValue Value(double value) {
        return new LengthValue(value, this);
    }
}

/// <summary>
///
/// </summary>
public class LengthValue : UnitValue<Length> {
    /// <summary>
    /// Initialises a new instance of an <see ref="LengthValue"/>
    /// </summary>
    public LengthValue(double value, Length unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator LengthValue(double value) {
        return Length.M.Value(value);
    }
}