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
/// A numeric value and its associated unit.
/// </summary>
public abstract class UnitValue<TUnit> where TUnit : Unit {
    /// <summary>
    /// Gets the value 
    /// </summary>
    public double Value { get; }

    /// <summary>
    /// Gets the unit
    /// </summary>
    public TUnit Unit { get; }

    /// <summary>
    /// Initialises a new instance of the <see ref="UnitValue"/>.
    /// </summary>
    public UnitValue(double value, TUnit unit) {
        Value = value;
        Unit = unit;
    }

    /// <summary>
    /// Implicitly convert the unit value to a double value.
    /// </summary>
    public static implicit operator double(UnitValue<TUnit>? value) {
        if (value is null) {
            throw new ApplicationException("Cannot convert from a null unit value.");
        }

        return value.ConvertFrom();
    }

    /// <summary>
    /// Converts the value from the unit to a double value.
    /// </summary>
    protected double ConvertFrom() {      
        return Unit.ConvertFrom(Value);
    }

    /// <summary>
    /// Gets the conversions for the unit value.
    /// </summary>
    public abstract Conversion<TUnit> To {
        get;
    }

    /// <summary>
    /// Extensions for the <see ref="UnitValue"/> class.
    /// </summary>
    public abstract class Conversion<T> where T : TUnit {
        private readonly UnitValue<T> _value;

        /// <summary>
        /// Initialises a new instance of the <see ref="Conversion"/> class with the specified value.
        /// </summary>
        protected Conversion(UnitValue<T> value) {
            _value = value;
        }

        /// <summary>
        /// Converts the unit value to a double in the specified unit.
        /// </summary>
        public double this[T unit] { 
            get {
                return unit.ConvertTo(_value.Unit.ConvertFrom(_value.Value));
            }
        }
    }
}

/// <summary>
/// Extensions for the <see ref="UnitValue"/> class.
/// </summary>
public static class UnitValueExtensions {
    /// <summary>
    /// Determines if the nullable unit value has a value
    /// </summary>
    public static bool HasValue<T>(this UnitValue<T>? unitValue) where T : Unit {
        return unitValue is not null;
    }
}