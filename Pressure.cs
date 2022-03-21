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
public sealed class Pressure : ScalarUnit {
    /// <summary>
    ///
    /// </summary>
    public static readonly Pressure Pascal = new("pascal", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Pressure Mpa = new("mpa", 1000000);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Pressure Psi = new("psi", 6894.7573);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Pressure Atm = new("atm", 101325);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Pressure Bar = new("bar", 100000);

    private Pressure(string name, double factor) : base (name, factor) {
    }

    /// <summary>
    /// Creates a pressure value with the specified value and this unit
    /// </summary>
    public PressureValue Value(double value) {
        return new PressureValue(value, this);
    }
}

/// <summary>
///
/// </summary>
public class PressureValue : UnitValue<Pressure> {
    /// <summary>
    /// Initialises a new instance of an <see ref="PressureValue"/>
    /// </summary>
    public PressureValue(double value, Pressure unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator PressureValue(double value) {
        return Pressure.Pascal.Value(value);
    }
}