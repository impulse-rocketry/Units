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
public sealed partial class Volume {
    /// <summary>
    ///
    /// </summary>
    public static readonly VolumeUnit M3 = new("m3", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly VolumeUnit Cc = new("cc", 0.000001);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly VolumeUnit In3 = new("in3", 1.6387064e-05);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly VolumeUnit Liter = new("liter", 0.001);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly VolumeUnit Cup = new("cup", 0.000236588);
}