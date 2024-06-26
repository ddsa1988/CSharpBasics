using System.Text.Json.Serialization;

namespace UsingAPI.Models;

public class Song {
    [JsonPropertyName("song")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("artist")] public string Artist { get; set; } = string.Empty;
    [JsonPropertyName("genre")] public string Genre { get; set; } = string.Empty;
    [JsonPropertyName("duration_ms")] public long Duration { get; set; }

    public override string ToString() {
        return "Song: " + Name +
               "\nArtist: " + Artist +
               "\nGenre: " + Genre +
               "\nDuration: " + Duration / 1000 + " seconds";
    }
}