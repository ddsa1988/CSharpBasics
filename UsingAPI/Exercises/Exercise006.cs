using System.Text.Json;
using UsingAPI.Models;

namespace UsingAPI.Exercises;

public class Exercise006 {
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string fileName = $"..{sepChar}..{sepChar}..{sepChar}Files{sepChar}people-data.json";

        List<Person> people1 = new List<Person>() {
            { new Person("Diego", new DateTime(1988, 1, 22), "ddsa@hotmail.com") },
            { new Person("Amanda", new DateTime(1993, 10, 16), "alnp@hotmail.com") },
            { new Person("Rodrigo", new DateTime(1993, 10, 12), "rdsa@hotmail.com") },
            { new Person("Tainara", new DateTime(1996, 4, 21), "tdsa@hotmail.com") },
            { new Person("Ivanice", new DateTime(1968, 8, 16), "irds@hotmail.com") },
            { new Person("Mirelli", new DateTime(2000, 5, 20), "mrds@hotmail.com") }
        };

        string writeJson = JsonSerializer.Serialize(people1);

        File.WriteAllText(fileName, writeJson);

        try {
            string readJson = File.ReadAllText(fileName);
            List<Person>? people2 = JsonSerializer.Deserialize<List<Person>>(readJson);

            PrintCollection.Print(people2, "\n");
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}