using Xunit;
using FluentAssertions;
using System.Text.Json;
using ImpulseRocketry.Units;
using ImpulseRocketry.Units.Json;

namespace ImpulseRocketry.Units.Tests;

public class UnitJsonConverterFactoryTests
{
    [Fact]
    public void CanConvert() {
        var factory = new UnitJsonConverterFactory();

        factory.CanConvert(typeof(TemperatureUnit)).Should().BeTrue();
    }

    [Fact]
    public void CreateConverter() {
        var factory = new UnitJsonConverterFactory();

        var connverter = factory.CreateConverter(typeof(TemperatureUnit), new JsonSerializerOptions());

        connverter.Should().NotBeNull();
        connverter.Should().BeOfType<UnitJsonConverter<TemperatureUnit>>();
    }
}