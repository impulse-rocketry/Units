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
public sealed partial class SurfaceTension {
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTensionUnit MNM = new("mN/m", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTensionUnit NM = new("N/m", 10e-3);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTensionUnit JM2 = new("J/m2", 10e-3);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTensionUnit DynCm = new("dyn/cm", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTensionUnit ErgCm2 = new("erg/cm2", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly SurfaceTensionUnit LbfFt = new("lbf/ft", 68.52e-6);
}
