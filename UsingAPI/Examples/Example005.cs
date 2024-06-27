using System.Text.Json;
using UsingAPI.Models;

namespace UsingAPI.Examples;

public class Example005 {
    public static void UserMain() {
        ShowBooks();
        Console.ReadKey();
    }

    private static async void ShowBooks() {
        using HttpClient client = new HttpClient();

        try {
            string answer = await client.GetStringAsync(
                "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");

            //Console.WriteLine(answer);

            List<Book>? books = JsonSerializer.Deserialize<List<Book>>(answer);

            PrintCollection.Print(books, "\n");

        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}