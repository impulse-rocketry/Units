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
[GenerateUnitValue]
public sealed partial class Temperature {
    /// <summary>
    ///
    /// </summary>
    public static readonly TemperatureUnit Kelvin = new("K", 1, 0);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly TemperatureUnit Fahrenheit = new("F", 0.55555556, 255.373);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly TemperatureUnit Celsius = new("C", 1, 273.15);
}

/// <summary>
///
/// </summary>
public sealed class TemperatureUnit : Unit {

    private readonly double _scale;
    private readonly double _offset;

    internal TemperatureUnit(string name, double scale, double offset) : base(name) {
        _scale = scale;
        _offset = offset;
    }

    /// <summary>
    ///
    /// </summary>
    internal override double ConvertFrom(double value) {
        return value * _scale + _offset;
    }

    /// <summary>
    ///
    /// </summary>
    internal override double ConvertTo(double value) {
        return (value - _offset) / _scale;
    }

    /// <summary>
    /// Creates a temperature value with the specified value and this unit
    /// </summary>
    public Temperature Value(double value) {
        return new Temperature(value, this);
    }
}
