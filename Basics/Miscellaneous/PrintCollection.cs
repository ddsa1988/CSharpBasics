namespace Basics.Miscellaneous;

public class PrintCollection {
    public static void Print<T>(IEnumerable<T> collection) {
        if (collection == null) return;

        int size = collection.Count();

        Console.Write("[ ");

        for (int i = 0; i < size - 1; i++) {
            Console.Write(collection.ElementAt(i) + ", ");
        }

        Console.WriteLine(collection.ElementAt(size - 1) + " ]\n");
    }
}