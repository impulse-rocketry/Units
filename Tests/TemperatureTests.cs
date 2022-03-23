using Xunit;
using FluentAssertions;
using ImpulseRocketry.Units;

namespace ImpulseRocketry.Units.Tests;

public class TemperatureTests
{
    [Fact]
    public void CelsiusToKelvin()
    {
        Temperature.Celsius.Value(-273.15).In.Kelvin.Should().Be(0);
        Temperature.Celsius.Value(0).In.Kelvin.Should().Be(273.15);
        Temperature.Celsius.Value(100).In.Kelvin.Should().Be(373.15);
    }

    [Fact]
    public void CelsiusToFahrenheit()
    {
        Temperature.Celsius.Value(-273.15).In.Fahrenheit.Should().BeApproximately(-459.67, 0.01);
        Temperature.Celsius.Value(0).In.Fahrenheit.Should().BeApproximately(32, 0.01);
        Temperature.Celsius.Value(100).In.Fahrenheit.Should().BeApproximately(212, 0.01);
    }

    [Fact]
    public void ImplicityCastDoubleToKelvin() {
        Temperature t = 42;
        t.In.Kelvin.Should().Be(42);
    }

    [Fact]
    public async void ImplicityCastToKelvin() {
        double t = Temperature.Celsius.Value(42);
        t.Should().Be(315.15);
    }
}