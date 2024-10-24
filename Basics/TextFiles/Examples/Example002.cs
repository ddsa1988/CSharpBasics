namespace Basics.TextFiles.Examples;

public class Example002 {
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = @$"TextFiles{sepChar}Files{sepChar}WriteSample.txt";

        WriteFile(filePath);
    }

    private static void WriteFile(string filePath) {
        if (File.Exists(filePath)) File.Delete(filePath);

        File.Create(filePath).Close();

        using StreamWriter writer = new StreamWriter(filePath);

        for (int i = 0; i < 20; i++) {
            writer.Write(i + " ");
        }
    }
}