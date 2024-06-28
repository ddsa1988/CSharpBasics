using System.Text.Json;
using UsingAPI.Models;

namespace UsingAPI.Examples;

public class Example002 {
    public static void UserMain() {
        ShowMovies();
        
        Console.ReadKey();
    }

    private static async void ShowMovies() {
        using HttpClient client = new HttpClient();

        try {
            string answer = await client.GetStringAsync(
                "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");

            //Console.WriteLine(answer);

            List<Movie>? movies = JsonSerializer.Deserialize<List<Movie>>(answer);

            PrintCollection.Print(movies, "\n");

        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}