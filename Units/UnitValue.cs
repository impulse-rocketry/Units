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

public abstract class UnitValue {
    
}

/// <summary>
///
/// </summary>
public abstract class UnitValue<TUnit> where TUnit : Unit {
    /// <summary>
    ///
    /// </summary>
    public double Value { get; }

    /// <summary>
    ///
    /// </summary>
    public TUnit Unit { get; }

    /// <summary>
    /// Initialises a new instance of the UnitValue.
    /// </summary>
    public UnitValue(double value, TUnit unit) {
        Value = value;
        Unit = unit;
    }

    /// <summary>
    ///
    /// </summary>
    public static implicit operator double(UnitValue<TUnit>? value) {
        if (value is null) {
            throw new ApplicationException("Cannot convert from a null unit value.");
        }

        return value.ConvertFrom();
    }

    /// <summary>
    ///
    /// </summary>
    protected double ConvertFrom() {      
        return Unit.ConvertFrom(Value);
    }

    /// <summary>
    ///
    /// </summary>
    public abstract Conversion<TUnit> In {
        get;
    }

    /// <summary>
    ///
    /// </summary>
    public abstract class Conversion<T> where T : TUnit {
        private readonly UnitValue<T> _value;

        /// <summary>
        ///
        /// </summary>
        protected Conversion(UnitValue<T> value) {
            _value = value;
        }

        /// <summary>
        ///
        /// </summary>
        public double this[T unit] { 
            get {
                return unit.ConvertTo(_value.Unit.ConvertFrom(_value.Value));
            }
        }
    }
}

/// <summary>
///
/// </summary>
public static class UnitValueExtensions {
    /// <summary>
    ///
    /// </summary>
    public static bool HasValue<T>(this UnitValue<T>? unitValue) where T : Unit {
        return unitValue is not null;
    }
}