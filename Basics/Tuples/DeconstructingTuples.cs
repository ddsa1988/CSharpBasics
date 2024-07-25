namespace Basics.Tuples;

public class DeconstructingTuples {
    public static void UserMain() {
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"a = {a}, b = {b}");

            (a, b) = (b, a);
            Console.WriteLine($"a = {a}, b = {b}");
        }

        Console.WriteLine();

        {
            (string, int) bob = ("Bob", 18);

            (string name, int age) = bob;
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

        Console.WriteLine();

        {
            Person p1 = new Person() { Name = "Bob", Age = 18 };

            (string name, int age) = p1;
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }

    private class Person {
        public string Name { get; init; } = string.Empty;
        public int Age { get; init; }

        public void Deconstruct(out string name, out int age) {
            name = Name;
            age = Age;
        }
    }
}