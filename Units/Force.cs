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
public sealed partial class Force {
    /// <summary>
    ///
    /// </summary>
    public static readonly ForceUnit N = new("N", 1);

    /// <summary>
    ///
    /// </summary>
    public static readonly ForceUnit Newton = new("N", 1);

    /// <summary>
    ///
    /// </summary>
    public static readonly ForceUnit Lbf = new("lbf", 4.4482216);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly ForceUnit Lb = new("lb", 4.4482216);
}