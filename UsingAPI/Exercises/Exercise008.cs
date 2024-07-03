using System.Text.Json;
using UsingAPI.Models;

namespace UsingAPI.Exercises;

public class Exercise008 {
    public static void UserMain() {
        GetSongs();
        Console.ReadKey();
    }

    private static async void GetSongs() {
        using HttpClient client = new HttpClient();

        try {
            string answer =
                await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

            // Console.WriteLine(answer);

            List<Song>? songs = JsonSerializer.Deserialize<List<Song>>(answer);

            if (songs == null) return;

            // PrintCollection.Print(songs, "\n");
            SongFilter.SongByKey(songs, "C#");
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            Console.WriteLine("Test");
        }
    }
}