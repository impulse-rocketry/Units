using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ImpulseRocketry.Units.Json;

/// <summary>
/// A <see ref="JsonConverter"/> for <see ref="Unit"/> types.
/// </summary>
public class UnitJsonConverter<T> : JsonConverter<T> where T : Unit {
    private static readonly Dictionary<string, T> NameToValueMap = typeof(UnitValue<>)
            .Assembly
            .GetTypes()
            .Where(t => t.IsAssignableTo(typeof(UnitValue<T>)))
            .First()
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(T))
            .Select(f => (T)f!.GetValue(null)!)
            .ToDictionary(x => x.Name);

    /// <summary>
    /// Reads a JSON string value and returns its represenetation as a <see ref="Unit"/>
    /// </summary>        
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        var unitString = reader.GetString()!;

        return NameToValueMap.TryGetValue(unitString, out var value)
            ? value
            : throw new ApplicationException($"Unable to parse unit {unitString}");
    }

    /// <summary>
    /// Writes a <see ref="Unit"/> as a JSON string value.
    /// </summary>
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) {
        writer.WriteStringValue(value.Name);
    }
}