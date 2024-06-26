using System.Text.Json.Serialization;

namespace UsingAPI.Models;

public class Country {
    [JsonPropertyName("nome")] public string Name { get; init; } = string.Empty;
    [JsonPropertyName("capital")] public string Capital { get; init; } = string.Empty;
    [JsonPropertyName("continente")] public string Continent { get; init; } = string.Empty;
    [JsonPropertyName("idioma")] public string Language { get; init; } = string.Empty;
    [JsonPropertyName("populacao")] public long Population { get; init; }

    public override string ToString() {
        return "Name: " + Name +
               "\nCapital: " + Capital +
               "\nContinent: " + Continent +
               "\nLanguage: " + Language +
               "\nPopulation: " + Population;
    }
}