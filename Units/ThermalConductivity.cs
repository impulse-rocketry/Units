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
public sealed partial class ThermalConductivity {
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivityUnit MWMK = new("mW/m K", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivityUnit WMK = new("W/m K", 10e-3);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivityUnit JCmSK = new("J/cm s K", 10e-5);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivityUnit KcalMHK = new("kcal/m h K", 859.845e-6);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivityUnit CalCmSK = new("cal/cm s K", 2.38846e-6);

    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivityUnit BtuFtHF = new("Btu/ft h F", 577.789e-6);

    /// <summary>
    ///
    /// </summary>
    public static readonly ThermalConductivityUnit BtuInFt2HF = new("Btu in/ft2 h F", 6.93347e-3);
}
