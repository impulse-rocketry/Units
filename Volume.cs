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
public sealed class Volume : ScalarUnit {
    /// <summary>
    ///
    /// </summary>
    public static readonly Volume MSec = new("m3", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Volume Kps = new("cc", 0.000001);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Volume Mph = new("in3", 1.6387064e-05);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Volume Fps = new("liter", 0.001);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly Volume NSec = new("cup", 0.000236588);

    private Volume(string name, double factor) : base (name, factor) {
    }  

    /// <summary>
    /// Creates a volume value with the specified value and this unit
    /// </summary>
    public VolumeValue Value(double value) {
        return new VolumeValue(value, this);
    }
}

/// <summary>
///
/// </summary>
public class VolumeValue : UnitValue<Volume> {
    /// <summary>
    /// Initialises a new instance of an <see ref="VolumeValue"/>
    /// </summary>
    public VolumeValue(double value, Volume unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator VolumeValue(double value) {
        return Volume.MSec.Value(value);
    }
}
