namespace Basics.TextFiles.Exercises;

public class Exercise003 {
    // Write a program that reads the contents of a text file and inserts the
    // line numbers at the beginning of each line, then rewrites the file contents.
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string sourceFilePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise003_File1.txt";
        string targetFilePath = $"..{sepChar}..{sepChar}..{sepChar}TextFiles{sepChar}Files{sepChar}Exercise003_File2.txt";

        InsertLineNumber(sourceFilePath, targetFilePath);
    }

    private static void InsertLineNumber(string sourceFilePath, string targetFilePath) {
        if (!File.Exists(sourceFilePath)) return;

        try {
            using var reader = new StreamReader(sourceFilePath);
            using StreamWriter write = File.CreateText(targetFilePath);

            int lineCounter = 0;

            while (!reader.EndOfStream) { 
                string? line = reader.ReadLine();
                lineCounter++;
               
                if(string.IsNullOrEmpty(line) || string.IsNullOrWhiteSpace(line)) {
                    write.WriteLine(line);
                } else {
                    write.WriteLine(lineCounter + " " + line);
                }
            }


        } catch (IOException) {
            Console.Error.WriteLine($"Can't read file '{sourceFilePath} and write file {targetFilePath}.'");
        } catch (Exception e) { 
            Console.Error.WriteLine (e.ToString());
        }
    }
}

