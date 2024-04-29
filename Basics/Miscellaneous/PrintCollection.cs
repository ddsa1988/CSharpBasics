namespace Basics.Miscellaneous;

public class PrintCollection<T> {
    public static void Print(IEnumerable<T> collection) {
        if (collection == null) return;

        int size = collection.Count();

        Console.Write("[ ");

        for (int i = 0; i < size - 1; i++) {
            Console.Write(collection.ElementAt(i) + ", ");
        }

        Console.WriteLine(collection.ElementAt(size - 1) + " ]\n");
    }
}