namespace Basics.Linq.Examples;

public class Example004 {
    // Lambda expressions
    public static void UserMain() {
        var dogs = new List<Dog>() {
            new Dog { Name = "Cereja", Age = 8 },
            new Dog { Name = "Amora", Age = 4 },
            new Dog { Name = "Ameixa", Age = 2 }
        };

        IEnumerable<string> names = dogs.Select(x => x.Name);

        Console.WriteLine("Names: {0}.", string.Join(", ", names));
    }

    private class Dog {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}