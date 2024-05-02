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
        const string a = "Diego" + " Alexandre";
        string b = "10" + 5; //Uses the ToString method to convert a non-string value

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

        const string text = @"string.Compare(strA, strB, ignoreCase) or string.CompareOrdinal(strA, strB): 
Less than zero => strA is less than strB
Greater than zero => strA is greater than strB
Zero => strA and strB are equal";

        Console.WriteLine($"{text}\n");

        Console.WriteLine("Char 'T' in ASCII = " + (byte)a[0]);
        Console.WriteLine("Char 't' in ASCII = " + (byte)b[0]);
        Console.WriteLine($"string.Compare({b}, {a}) = {string.CompareOrdinal(b, a)}");
        Console.WriteLine($"string.Compare({a}, {b}) = {string.CompareOrdinal(a, b)}");
        Console.WriteLine($"string.Compare({b}, {c}) = {string.CompareOrdinal(b, c)}");
    }

    public static void SortArrayOfStrings() {
        string[] names = ["Rodrigo", "Diego", "Mirelle", "Ivanice", "Zeus", "Amanda", "Tainara"];
        int outerLoopSize = names.Length - 1;

        PrintCollection.Print(names);

        for (int i = 0; i < outerLoopSize; i++) {
            int innerLoopSize = outerLoopSize - i;

            for (int j = 0; j < innerLoopSize; j++) {
                string actual = names[j];
                string next = names[j + 1];

                int compareResult = string.CompareOrdinal(actual, next);

                if (compareResult <= 0) continue;

                names[j] = next;
                names[j + 1] = actual;
            }
        }

        PrintCollection.Print(names);
    }
}