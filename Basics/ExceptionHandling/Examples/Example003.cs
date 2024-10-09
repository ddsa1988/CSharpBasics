namespace Basics.ExceptionHandling.Examples;

public class Example003 {
    public static void UserMain() {
        string fileName = "WrongTextFile.txt";

        ReadTextFile(fileName);
    }

    private static void ReadTextFile(string fileName) {
        if (!File.Exists(fileName)) {
            Console.WriteLine($"File {fileName} does not exist.");
            return;
        }

        StreamReader reader = new StreamReader(fileName);

        using (reader) {
            while (!reader.EndOfStream) {
                string? line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}