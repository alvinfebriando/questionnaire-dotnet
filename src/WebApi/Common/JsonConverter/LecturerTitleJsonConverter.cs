using System.Text.Json;
using System.Text.Json.Serialization;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.WebApi.Common.JsonConverter;

public class LecturerTitleJsonConverter : JsonConverter<LecturerTitle>
{
    public override LecturerTitle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return (LecturerTitle)Enum.Parse(typeToConvert, reader.GetString(), true);
    }

    public override void Write(Utf8JsonWriter writer, LecturerTitle value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}