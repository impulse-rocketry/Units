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
public sealed class ThermalConductivity : ScalarUnit {
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivity MWMK = new("mW/m K", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivity WMK = new("W/m K", 10e-3);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivity JCmSK = new("J/cm s K", 10e-5);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivity KcalMHK = new("kcal/m h K", 859.845e-6);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivity CalCmSK = new("cal/cm s K", 2.38846e-6);

    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivity BtuFtHF = new("Btu/ft h F", 577.789e-6);

    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivity BtuInFt2HF = new("Btu in/ft2 h F", 6.93347e-3);

    private ThermalConductivity(string name, double factor) : base (name, factor) {
    }
    
    /// <summary>
    /// Creates a thermal conductivity value with the specified value and this unit
    /// </summary>
    public ThermalConductivityValue Value(double value) {
        return new ThermalConductivityValue(value, this);
    }
}

/// <summary>
///
/// </summary>
public class ThermalConductivityValue : UnitValue<ThermalConductivity> {
    /// <summary>
    /// Initialises a new instance of an <see ref="ThermalConductivityValue"/>
    /// </summary>
    public ThermalConductivityValue(double value, ThermalConductivity unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator ThermalConductivityValue(double value) {
        return ThermalConductivity.MWMK.Value(value);
    }
}