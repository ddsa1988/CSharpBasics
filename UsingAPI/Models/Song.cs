using System.Text.Json.Serialization;

namespace UsingAPI.Models;

public class Song {
    [JsonPropertyName("song")] public string Name { get; init; } = string.Empty;
    [JsonPropertyName("artist")] public string Artist { get; init; } = string.Empty;
    [JsonPropertyName("genre")] public string Genre { get; init; } = string.Empty;
    [JsonPropertyName("duration_ms")] public long Duration { get; init; }

    public override string ToString() {
        return "Song: " + Name +
               "\nArtist: " + Artist +
               "\nGenre: " + Genre +
               "\nDuration: " + Duration / 1000 + " seconds";
    }
}