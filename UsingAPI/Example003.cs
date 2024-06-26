namespace UsingAPI;

public class Example003 {
    public static void UserMain() {
        ShowCountries();
        Console.ReadKey();
    }

    private static async void ShowCountries() {
        using HttpClient client = new HttpClient();

        try {
            string answer = await client.GetStringAsync(
                "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
            Console.WriteLine(answer);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}