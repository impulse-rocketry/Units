using Xunit;
using FluentAssertions;
using System.Text;
using System.Text.Json;
using ImpulseRocketry.Units.Json;

namespace ImpulseRocketry.Units.Tests;

public class UnitJsonConverterTests
{
    [Fact]
    public void Read() {
        var converter = new UnitJsonConverter<TemperatureUnit>();

        var jsonString = "\"C\"";
        var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(jsonString));
        reader.Read();

        var result = converter.Read(ref reader, typeof(TemperatureUnit), new JsonSerializerOptions());
        result.Should().Be(Temperature.Celsius);
    }
}