using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ImpulseRocketry.Units.Json;

/// <summary>
///
/// </summary>
public class UnitJsonConverter<T> : JsonConverter<T> where T : Unit {
    private static readonly Dictionary<string, T> NameToValueMap = typeof(T)
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(Unit))
            .Select(f => (T)f!.GetValue(null)!).ToDictionary(x => x.Name);

    /// <summary>
    ///
    /// </summary>        
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        var unitString = reader.GetString()!;

        return NameToValueMap.TryGetValue(unitString, out var value)
            ? value
            : throw new ApplicationException($"Unable to parse unit {unitString}");
    }

    /// <summary>
    ///
    /// </summary>
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) {
        writer.WriteStringValue(value.Name);
    }
}