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
        const string a = "Diego" + " Alexndre";
        string b = "10" + 5; //Uses the ToString method to convert a nonstring value

        Console.WriteLine("\"Diego\" + \" Alexandre\" = " + a);
        Console.WriteLine("string \"10\" + int 5 = " + b);
    }

    public static void Comparison() {
        const string a = "Test";
        const string b = "test";
        const string c = "test";

        Console.WriteLine($"{a} == {b} = {a == b}");
        Console.WriteLine($"{b} == {c} = {b == c}");
        Console.WriteLine();

        string text = @"String.Compare(string1, string2, ignoreCase): 
-1 if string1 comes before string2
 1 if string2 comes before string1
 0 if their position is the same (string1 and string2 are identical)";

        Console.WriteLine($"{text}\n");

        Console.WriteLine("Char 'T' in ASCII = " + (byte)a[0]);
        Console.WriteLine("Char 't' in ASCII = " + (byte)b[0]);
        Console.WriteLine($"string.Compare({b}, {a}) = {string.Compare(b, a)}");
        Console.WriteLine($"string.Compare({a}, {b}) = {string.Compare(a, b)}");
        Console.WriteLine($"string.Compare({b}, {c}) = {string.Compare(b, c)}");
    }

    public static void SortArrayOfStrings() {
        string[] names = ["Rodrigo", "Diego", "Ivanice", "Bruno", "Amanda", "Tainara"];
        Array.Sort( names );

        PrintCollection<string>.Print(names);

        for (int i = 0; i < names.Length; i++) {
            for (int j = i + 1; j < names.Length; j++) {

                string actual = names[i];
                string next = names[j];

                int compareResult = string.Compare(actual, next);

                if (compareResult == 1) {
                    names[i] = next;
                    names[j] = actual;
                }
            }
        }

        PrintCollection<string>.Print(names);
    }
}