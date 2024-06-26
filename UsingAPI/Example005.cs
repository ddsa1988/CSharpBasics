namespace UsingAPI;

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
            Console.WriteLine(answer);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}