using System.Text.Json.Serialization;

namespace ProjectApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEmun
    {
        RH,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}
