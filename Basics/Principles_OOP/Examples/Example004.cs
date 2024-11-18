namespace Basics.Principles_OOP.Examples;

public class Example004 {
    // Interfaces
    public static void UserMain() {
        var test1 = new Test1();
        var test2 = new Test2();

        int[] numbers = test1.GetValues();
        string[] names = test2.GetValues();

        Console.WriteLine("Numbers: {0}.", string.Join(", ", numbers));
        Console.WriteLine("Names: {0}.", string.Join(", ", names));
    }

    private class Test1 : IList<int> {
        public int[] GetValues() {
            return [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        }
    }

    private class Test2 : IList<string> {
        public string[] GetValues() {
            return ["Diego", "Amanda"];
        }
    }
}

public interface IList<T> {
    T[] GetValues();
}