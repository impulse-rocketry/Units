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

using Xunit;
using FluentAssertions;
using ImpulseRocketry.Units;

namespace ImpulseRocketry.Units.Tests;

public class TemperatureTests
{
    [Fact]
    public void CelsiusToKelvin()
    {
        Temperature.C.Value(-273.15).To.K.Should().Be(0);
        Temperature.C.Value(0).To.K.Should().Be(273.15);
        Temperature.C.Value(100).To.K.Should().Be(373.15);
    }

    [Fact]
    public void CelsiusToFahrenheit()
    {
        Temperature.C.Value(-273.15).To.F.Should().BeApproximately(-459.67, 0.01);
        Temperature.C.Value(0).To.F.Should().BeApproximately(32, 0.01);
        Temperature.C.Value(100).To.F.Should().BeApproximately(212, 0.01);
    }

    [Fact]
    public void ImplicityCastDoubleToKelvin() {
        Temperature t = 42;
        t.To.K.Should().Be(42);
    }

    [Fact]
    public void ImplicityCastToKelvin() {
        double t = Temperature.C.Value(42);
        t.Should().Be(315.15);
    }
}