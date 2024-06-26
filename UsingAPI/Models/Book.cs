using System.Text.Json.Serialization;

namespace UsingAPI.Models;
public class Book {
    [JsonPropertyName("titulo")] public string Title { get; init; } = string.Empty;
    [JsonPropertyName("autor")] public string Author { get; init; } = string.Empty;
    [JsonPropertyName("genero")] public string Genre { get; init; } = string.Empty;
    [JsonPropertyName("editora")] public string Publisher { get; init; } = string.Empty;
    [JsonPropertyName("ano_publicacao")] public long Year { get; init; }
    [JsonPropertyName("paginas")] public long Pages { get; init; }

    public override string ToString() {
        return "Title: " + Title +
               "\nAuthor: " + Author +
               "\nYear: " + Year +
               "\nGenre: " + Genre +
               "\nPages: " + Pages +
               "\nPublisher: " + Publisher;
    }
}

