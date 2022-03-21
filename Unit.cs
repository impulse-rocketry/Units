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
public abstract class Unit {
    private readonly string _name;

    /// <summary>
    /// Initialises a new instance of the <see cref="Unit"/> class.
    /// </summary>
    public Unit(string name) {
        _name = name;
    }

    /// <summary>
    /// Gets the name of the unit.
    /// </summary>
    public string Name => _name;

    /// <summary>
    /// 
    /// </summary>
    internal abstract double ConvertFrom(double value);

    /// <summary>
    /// 
    /// </summary>
    internal abstract double ConvertTo(double value);
}

/// <summary>
///
/// </summary>
public static class UnitExtensions {
    /// <summary>
    ///
    /// </summary>
    public static double In(this double value, Unit unit) {
        return unit.ConvertTo(value);
    }
}

