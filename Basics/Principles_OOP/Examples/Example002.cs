namespace Basics.Principles_OOP.Examples;

public class Example002 {
    public static void UserMain() {
        var p1 = new Person() { Name = "Diego" };
        var d1 = new Dog() { Name = "Amora" };

        Person? p2 = null;
        Person? p3 = null;

        object obj1 = p1;
        object obj2 = d1;

        try {
            p2 = (Person)obj1;
        } catch (InvalidCastException) {
            Console.WriteLine($"{nameof(obj1)} cannot be down casted to {nameof(Person)}.\n");
        }

        try {
            p3 = (Person)obj2;
        } catch (InvalidCastException) {
            Console.WriteLine($"{nameof(obj2)} cannot be down casted to {nameof(Person)}.\n");
        }

        Console.WriteLine("{0} -> {1}", nameof(p1), p1);
        Console.WriteLine("{0} -> {1}", nameof(p2), p2);
        Console.WriteLine("{0} -> {1}", nameof(p3), p3);

        Console.WriteLine("{0} -> {1}", nameof(obj1), obj1);
        Console.WriteLine("{0} -> {1}", nameof(obj2), obj2);
    }

    private class Person {
        public string Name { get; set; } = string.Empty;

        public override string ToString() {
            return "Name: " + Name;
        }
    }

    private class Dog {
        public string Name { get; set; } = string.Empty;

        public override string ToString() {
            return "Name: " + Name;
        }
    }
}