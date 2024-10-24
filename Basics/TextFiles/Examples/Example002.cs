namespace Basics.TextFiles.Examples;

public class Example002 {
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Example002.txt";

        WriteFile(filePath);
    }

    private static void WriteFile(string filePath) {
        if (File.Exists(filePath)) File.Delete(filePath);

        try {
            File.Create(filePath).Close();

            using StreamWriter writer = new StreamWriter(filePath);

            for (int i = 0; i < 20; i++) {
                writer.Write(i + " ");
            }

        } catch (FileNotFoundException) {
            Console.Error.WriteLine("File not found: '{0}'.", filePath);
        } catch (DirectoryNotFoundException) {
            Console.Error.WriteLine("Directory not found: '{0}'.", filePath);
        } catch (IOException) {
            Console.Error.WriteLine("Cannot write file: '{0}'.", filePath);
        }
    }
}