using System.Text.Json.Serialization;

namespace ProjectApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEmun
    {
        Manha,
        Tarde,
        Noite
    }
}
