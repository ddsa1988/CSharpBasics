namespace Basics.Linq.Examples;

public class Example005 {
    // Lambda expressions with anonymous types
    public static void UserMain() {
        var dogs = new List<Dog>() {
            new Dog { Name = "Cereja", Age = 8 },
            new Dog { Name = "Amora", Age = 4 },
            new Dog { Name = "Ameixa", Age = 2 }
        };

        var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
        
        Console.WriteLine(string.Join("\n", newDogsList));
    }

    private class Dog {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}