namespace Basics.Linq.Examples;

public class Example006 {
    // Sorting with lambda expressions
    public static void UserMain() {
        var dogs = new List<Dog>() {
            new Dog { Name = "Cereja", Age = 1 },
            new Dog { Name = "Amora", Age = 4 },
            new Dog { Name = "Ameixa", Age = 2 }
        };

        IEnumerable<Dog> sortedDogs = dogs.OrderByDescending(x => x.Age);

        foreach (Dog dog in sortedDogs) {
            Console.WriteLine("Dog {0} is {1} years old.", dog.Name, dog.Age);
        }
    }

    private class Dog {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}