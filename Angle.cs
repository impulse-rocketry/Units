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
public sealed class Angle : ScalarUnit {
    /// <summary>
    ///
    /// </summary>
    public static readonly Angle Degree = new("degree", 0.01745329252);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Angle Degrees = new("degrees", 0.01745329252);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Angle Radian = new("radian", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Angle Radians = new("radians", 1);

    private Angle(string name, double factor) : base (name, factor) {
    }
    
    /// <summary>
    /// Creates an angle value with the specified value and this unit
    /// </summary>
    public AngleValue Value(double value) {
        return new AngleValue (value,this);
    }
}

/// <summary>
///
/// </summary>
public class AngleValue : UnitValue<Angle> {
    /// <summary>
    /// Initialises a new instance of an <see ref="AngleValue"/>
    /// </summary>
    public AngleValue(double value, Angle unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator AngleValue(double value) {
        return Angle.Radian.Value(value);
    }
}