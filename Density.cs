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
public sealed class Density : ScalarUnit {
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Density KgM3 = new("kg/m3", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Density GCc = new("g/cc", 1000);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Density LbFt3 = new("lb/ft3", 16.018463);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Density LbmFt3 = new("lbm/ft3", 16.018463);

    private Density(string name, double factor) : base (name, factor) {
    }

    /// <summary>
    /// Creates a density value with the specified value and this unit
    /// </summary>
    public DensityValue Value(double value) {
        return new DensityValue(value, this);
    }
}

/// <summary>
///
/// </summary>
public class DensityValue : UnitValue<Density> {
    /// <summary>
    /// Initialises a new instance of an <see ref="DensityValue"/>
    /// </summary>
    public DensityValue(double value, Density unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator DensityValue(double value) {
        return Density.KgM3.Value(value);
    }
}