using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ImpulseRocketry.Units.Json;

/// <summary>
///
/// </summary>
public class UnitJsonConverterFactory : JsonConverterFactory {
    /// <summary>
    ///
    /// </summary>
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsAssignableTo(typeof(Unit));

    /// <summary>
    ///
    /// </summary>
    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options) => (JsonConverter)Activator.CreateInstance(
        typeof(UnitJsonConverter<>).MakeGenericType(new Type[] { type }),
        BindingFlags.Instance | BindingFlags.Public,
        binder: null,
        args: Array.Empty<object>(),
        culture: null)!;
}