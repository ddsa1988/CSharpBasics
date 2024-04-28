namespace Basics.Strings;

public class StringType {
    public static void Basics() {
        const string myName = "Diego dos Santos Alexandre";
        char pathSepChar = Path.DirectorySeparatorChar;

        Console.WriteLine("String basics:\n");
        Console.WriteLine("This system path separator char: " + pathSepChar);
        Console.WriteLine("My name is " + myName);
        Console.WriteLine($"My name length is {myName.Length} characters long");
        Console.WriteLine("My name all upper case is " + myName.ToUpper());
        Console.WriteLine("My name all lower case is " + myName.ToLower());
        Console.WriteLine("My name contains the letter S: " + myName.Contains('S'));
        Console.WriteLine("Replace the 'e' for 'E' in my name: " + myName.Replace('e', 'E'));
    }

    public static void Verbatim() {
        const string a = "\\\\server\\file-share\\hello-world.cs"; //With escape sequence
        const string b = @"\\server\file-share\hello-world.cs"; //With verbatim string
        const string c = @"<customer id=""123""></customer>";

        Console.WriteLine("String verbatim:\n");
        Console.WriteLine("String a = " + a);
        Console.WriteLine("String b = " + b);
        Console.WriteLine("String a == b: " + a == b);
        Console.WriteLine("String c = " + c);
    }

    public static void Concatenation() {
        
    }
}