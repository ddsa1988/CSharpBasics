namespace Basics.Strings.Examples;

public class Example004 {
    public static void UserMain() {
        string sample = "amanda letícia nunes perna";

        List<int> indexes = FindAllOccurrences(sample, "a");

        foreach (int index in indexes) {
            Console.Write(index + " ");
        }
    }

    private static List<int> FindAllOccurrences(string source, string search) {
        if (string.IsNullOrEmpty(source) || string.IsNullOrWhiteSpace(source)) {
            throw new ArgumentException("String is empty", nameof(source));
        }

        if (string.IsNullOrEmpty(search) || string.IsNullOrWhiteSpace(search)) {
            throw new ArgumentException("String is empty", nameof(search));
        }

        List<int> indexes = new List<int>();

        int index = source.IndexOf(search, 0);

        while (index != -1) {
            indexes.Add(index);
            index = source.IndexOf(search, index + 1);
        }

        return indexes;
    }
}
