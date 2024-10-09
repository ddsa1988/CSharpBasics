namespace Basics.ExceptionHandling.Examples;

public class Example001 {
    public static void UserMain() {
        string fileName = "WrongTextFile.txt";
        ReadFile(fileName);
    }

    private static void ReadFile(string fileName) {
        TextReader? reader = null;
        try {
            reader = new StreamReader(fileName);
            string? line = reader.ReadLine();

            Console.WriteLine(line);

        } catch (FileNotFoundException e) {
            Console.WriteLine($"The file '{fileName}' is not found.");
        } catch (IOException e) {
            Console.WriteLine(e.StackTrace);
        } finally {
            if (reader != null) reader.Close();
        }
    }
}