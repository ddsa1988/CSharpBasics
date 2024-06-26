namespace UsingAPI;

public class Example004 {
    public static void UserMain() {
        ShowCars();
        Console.ReadKey();
    }

    private static async void ShowCars() {
        using HttpClient client = new HttpClient();

        try {
            string answer = await client.GetStringAsync(
                "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
            Console.WriteLine(answer);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}