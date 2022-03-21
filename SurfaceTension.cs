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
public sealed class SurfaceTension : ScalarUnit {
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTension MNM = new("mN/m", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTension NM = new("N/m", 10e-3);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTension JM2 = new("J/m2", 10e-3);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTension DynCm = new("dyn/cm", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTension ErgCm2 = new("erg/cm2", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTension LbfFt = new("lbf/ft", 68.52e-6);

    private SurfaceTension(string name, double factor) : base (name, factor) {
    }
    
    /// <summary>
    /// Creates a surface tension value with the specified value and this unit
    /// </summary>
    public SurfaceTensionValue Value(double value) {
        return new SurfaceTensionValue(value, this);
    }
}

/// <summary>
///
/// </summary>
public class SurfaceTensionValue : UnitValue<SurfaceTension> {
    /// <summary>
    /// Initialises a new instance of an <see ref="SurfaceTensionValue"/>
    /// </summary>
    public SurfaceTensionValue(double value, SurfaceTension unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator SurfaceTensionValue(double value) {
        return SurfaceTension.MNM.Value(value);
    }
}