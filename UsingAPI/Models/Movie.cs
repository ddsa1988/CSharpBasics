using System.Text.Json.Serialization;

namespace UsingAPI.Models;

public class Movie {
    [JsonPropertyName("title")] public string Title { get; init; } = string.Empty;
    [JsonPropertyName("year")] public string Year { get; init; } = string.Empty;
    [JsonPropertyName("imDbRating")] public string Rating { get; init; } = string.Empty;

    public override string ToString() {
        return "Title: " + Title +
               "\nYear: " + Year +
               "\nRating: " + Rating;
    }
}