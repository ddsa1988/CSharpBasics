namespace UsingAPI.Models;

public class PrintCollection {
    public static void Print<T>(IEnumerable<T>? collection, string sep) {
        if (collection == null) return;

        List<T>? list = collection.ToList();

        foreach (T item in list) {
            Console.WriteLine(item + $"{sep}");
        }
    }
}