using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace UsingAPI.Models;

public class Song {
    private readonly string[] _tones = ["C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"];
    [JsonPropertyName("song")] public string Name { get; init; } = string.Empty;
    [JsonPropertyName("artist")] public string Artist { get; init; } = string.Empty;
    [JsonPropertyName("genre")] public string Genre { get; init; } = string.Empty;
    [JsonPropertyName("duration_ms")] public long Duration { get; init; }
    [JsonPropertyName("key")] public int Key { get; init; }

    public string Tone {
        get {
            bool isKeyValid = Key >= 0 && Key < _tones.Length;

            return isKeyValid ? _tones[Key] : string.Empty;
        }
    }

    public override string ToString() {
        return "Song: " + Name +
               "\nArtist: " + Artist +
               "\nGenre: " + Genre +
               "\nDuration: " + Duration / 1000 + " seconds" +
               "\nTone: " + Tone;
    }

    public override int GetHashCode() {
        return Name.GetHashCode() + Artist.GetHashCode();
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;

        try {
            Song other = (Song)obj;
            return Name == other.Name && Artist == other.Artist;
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        return false;
    }
}