namespace Basics.Strings.Examples;

public class Example006 {
    public static void UserMain() {
        char[] separators = [' ', ',', '.'];
        const string listOfBeers = "Amstel, Heineken, Tuborg, Becks";

        Console.WriteLine("String sample: {0}.\n", listOfBeers);

        {
            string[] beers = listOfBeers.Split(separators);
            Console.WriteLine("Array size after split: " + beers.Length);

            foreach (string beer in beers) {
                Console.Write($"'{beer}'" + " ");
            }
        }

        Console.WriteLine('\n');

        {
            string[] beers = listOfBeers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Array size after split: " + beers.Length);

            foreach (string beer in beers) {
                Console.Write($"'{beer}'" + " ");
            }
        }
    }
}