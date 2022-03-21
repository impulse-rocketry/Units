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
public sealed class Viscosity : ScalarUnit {
    /// <summary>
    ///
    /// </summary>
    public static readonly Viscosity uNsM2 = new("μN s/m2", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Viscosity NSM2 = new("N s/m2", 10e-6);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Viscosity GCmS = new("g/cm s", 10e-5);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Viscosity KgMS = new("kg/m s", 10e-6);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Viscosity BFtH = new("b/ft h", 2.41909e-3);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Viscosity KgFSM2 = new("kgf s/m2", 101.972e-9);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Viscosity LbfSIn2 = new("lbf s/in2", 145.038e-12);

    private Viscosity(string name, double factor) : base (name, factor) {
    }
    
    /// <summary>
    /// Creates a viscosity value with the specified value and this unit
    /// </summary>
    public ViscosityValue Value(double value) {
        return new ViscosityValue(value, this);
    }
}

/// <summary>
///
/// </summary>
public class ViscosityValue : UnitValue<Viscosity> {
    /// <summary>
    /// Initialises a new instance of an <see ref="ViscosityValue"/>
    /// </summary>
    public ViscosityValue(double value, Viscosity unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator ViscosityValue(double value) {
        return Viscosity.uNsM2.Value(value);
    }
}