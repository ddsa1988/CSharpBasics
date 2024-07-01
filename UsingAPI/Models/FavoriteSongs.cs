using System.Text;
using System.Text.Json;

namespace UsingAPI.Models;

public class FavoriteSongs {
    public string Name { get; init; }
    public List<Song> songs { get; }

    public FavoriteSongs(string name) {
        Name = name;
        songs = new List<Song>();
    }

    public bool AddSong(Song song) {
        if (songs.Contains(song)) return false;

        songs.Add(song);

        return true;
    }

    public void ToJson() {
        string json = JsonSerializer.Serialize(new {
            name = Name,
            listSongs = songs
        });

        char sepChar = Path.DirectorySeparatorChar;
        string fileName = $"..{sepChar}..{sepChar}..{sepChar}Files{sepChar}favorite-songs-{Name}.json";

        File.WriteAllText(fileName, json);

        Console.WriteLine($"File created at {Path.GetFullPath(fileName)}");
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        if (songs.Count == 0) return sb.ToString();

        sb.Append("Favorite songs:");

        foreach (Song song in songs) {
            sb.Append("\n" + song + "\n");
        }

        return sb.ToString();
    }
}