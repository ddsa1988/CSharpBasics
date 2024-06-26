using System.Text.Json.Serialization;

namespace UsingAPI.Models;

public class Car {
    [JsonPropertyName("marca")] public string Brand { get; init; } = string.Empty;
    [JsonPropertyName("modelo")] public string Model { get; init; } = string.Empty;
    [JsonPropertyName("tipo")] public string Type { get; init; } = string.Empty;
    [JsonPropertyName("motor")] public string Engine { get; init; } = string.Empty;
    [JsonPropertyName("transmissao")] public string Transmission { get; init; } = string.Empty;
    [JsonPropertyName("ano")] public long Year { get; init; }

    public override string ToString() {
        return "Brand: " + Brand +
               "\nModel: " + Model +
               "\nYear: " + Year +
               "\nType: " + Type +
               "\nEngine: " + Engine +
               "\nTransmission: " + Transmission;
    }
}

