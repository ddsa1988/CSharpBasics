using System.Text.Json;
using UsingAPI.Models;

namespace UsingAPI.Exercises;

public class Exercise005 {
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string fileName = $"..{sepChar}..{sepChar}..{sepChar}Files{sepChar}person-data.json";

        Person p1 = new Person("Diego", new DateTime(1988, 1, 22), "diego@hotmail.com");

        string writeJson = JsonSerializer.Serialize(p1);
        File.WriteAllText(fileName, writeJson);

        try {
            string readJson = File.ReadAllText(fileName);
            Person? p2 = JsonSerializer.Deserialize<Person>(readJson);
            Console.WriteLine(p2);
        } catch (Exception e) {
            Console.WriteLine(e);
        }
    }
}