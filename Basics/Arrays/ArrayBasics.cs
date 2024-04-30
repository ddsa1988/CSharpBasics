namespace Basics.Arrays;

public class ArrayBasics {
    public static void Basics() {
        char[] vowels = ['a', 'e', 'i', 'o', 'u'];

        const int first = 0;
        int last1 = vowels.Length - 1;
        Index last2 = ^1; //It's equal to vowels.Length - 1

        Console.Write("Array vowels: ");
        PrintCollection<char>.Print(vowels);
        Console.WriteLine($"vowels[{first}] = {vowels[first]}");
        Console.WriteLine($"vowels[{last1}] = {vowels[last1]}");
        Console.WriteLine($"vowels[{last2}] = {vowels[last2]}");
        Console.WriteLine();

        const int elements = 5;
        
        PointStruct[] p1 = new PointStruct[elements]; //Struct is a value-type
        PointClass[] p2 = new PointClass[elements]; //Only allocates the references

        Console.WriteLine(p1[0].X);
        Console.WriteLine(p2[0]?.X.ToString() ?? "NULL");

        p2[0] = new PointClass(); //Instantiate a new PointClass object
        Console.WriteLine(p2[0]?.X.ToString() ?? "NULL");
        Console.WriteLine();

        const int sliceStart = 1;
        const int sliceEnd = 3;

        char[] arraySlice1 = vowels.Skip(sliceStart).Take(sliceEnd).ToArray();
        char[] arraySlice2 = vowels[sliceStart..sliceEnd];

        Console.Write($"Array slice => vowels.Skip({sliceStart}).Take({sliceEnd}).ToArray(): ");
        PrintCollection<char>.Print(arraySlice1);

        Console.Write($"Array slice => vowels[{sliceStart}..{sliceEnd}]: ");
        PrintCollection<char>.Print(arraySlice2);
    }

    private struct PointStruct {
        public int X { get; set; }
        public int Y { get; set; }
    }

    private class PointClass {
        public int X { get; set; }
        public int Y { get; set; }
    }
}