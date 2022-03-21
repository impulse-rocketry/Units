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
public sealed class MassFlow : ScalarUnit {
    /// <summary>
    ///
    /// </summary>
    public static readonly MassFlow KgSec = new("kg/sec", 1);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly MassFlow LbSec = new("lb/sec", 0.45359237);
    
    /// <summary>
    ///
    /// </summary>
    public static readonly MassFlow LbmSec = new("lbm/sec", 0.45359237);

    private MassFlow(string name, double factor) : base (name, factor) {
    }

    /// <summary>
    /// Creates a mass flow value with the specified value and this unit
    /// </summary>
    public MassFlowValue Value(double value) {
        return new MassFlowValue(value, this);
    }
}

/// <summary>
///
/// </summary>
public class MassFlowValue : UnitValue<MassFlow> {
    /// <summary>
    /// Initialises a new instance of an <see ref="MassFlowValue"/>
    /// </summary>
    public MassFlowValue(double value, MassFlow unit) : base(value, unit)
    {
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator MassFlowValue(double value) {
        return MassFlow.KgSec.Value(value);
    }
}