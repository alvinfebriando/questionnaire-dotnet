using System.Text.Json;
using System.Text.Json.Serialization;
using Questionnaire.Domain.Entities;

namespace Questionnaire.WebApi.Common.JsonConverter;

public class LecturerJsonConverter : JsonConverter<Lecturer>
{
    public override Lecturer? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, Lecturer value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("id", value.Id);
        var json = JsonSerializer.Serialize(value, new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() }
        });
        using (var document = JsonDocument.Parse(json))
        {
            foreach (var property in document.RootElement.EnumerateObject())
            {
                property.WriteTo(writer);
            }
        }

        writer.WriteEndObject();
    }
}