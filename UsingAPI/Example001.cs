using System.Text.Json;
using UsingAPI.Models;

namespace UsingAPI;

public class Example001 {
    public static void UserMain() {
        ShowSongs();
        Console.ReadKey();
    }

    private static async void ShowSongs() {
        using HttpClient client = new HttpClient();

        try {
            string answer =
                await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

            List<Song>? songs = JsonSerializer.Deserialize<List<Song>>(answer);

            if (songs == null) return;

            Console.WriteLine(songs.Count);

            for (int i = 0; i < 5 && i < songs.Count; i++) {
                Console.WriteLine(songs[i] + "\n");
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}