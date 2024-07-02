using System.Text.Json;
using UsingAPI.Models;

namespace UsingAPI.Exercises;

public class Exercise007 {
    public static void UserMain() {
        const int age = 30;
        char sepChar = Path.DirectorySeparatorChar;
        string fileName = $"..{sepChar}..{sepChar}..{sepChar}Files{sepChar}people-data.json";

        if (!File.Exists(fileName)) return;

        try {
            string json = File.ReadAllText(fileName);
            List<Person>? people = JsonSerializer.Deserialize<List<Person>>(json);

            if (people == null) return;

            IEnumerable<string> filteredNames = people.Where((p => p.Age == age)).Select((p => p.Name));

            PrintCollection.Print(filteredNames, "");
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}