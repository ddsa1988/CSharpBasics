namespace Basics.Generics;

/*
    where T : base-class => Base-class constraint
    where T : interface => Interface constraint
    where T : class => Reference-type constraint
    where T : class? => Nullable reference-type constraint
    where T : struct => Value-type constraint (excludes Nullable types)
    where T : unmanaged => Unmanaged constraint
    where T : new () => Parameterless constructor constraint
    where U : T => Naked type constraint
   
    Types in C#where T : notnull => Non-nullable value type, or (from C# 8) a non-nullable reference type
 */


public class GenericConstraints {
    public static void UserMain() {
        IEnumerable<Person> people1 = new Person[] { new Person("Diego"), new Person("Amanda") };
        ICollection<Person> people2 = new Person[] { new Person("Diego"), new Person("Amanda") };
        List<Person> people3 = new List<Person>() { new Person("Diego"), new Person("Amanda") };

        List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Print(people1);
        Console.WriteLine();

        Print(people2);
        Console.WriteLine();

        Print(people3);
        Console.WriteLine();

        //Print(numbers); //Compile error
    }

    public static void Print<T>(IEnumerable<T> collection) where T : Person {
        List<T> list = collection.ToList();

        foreach (T item in list) {
            Console.WriteLine(item);
        }
    }

    //public static int Compare<T>(T a, T b) {
    //    return a == b; // Operator '==' cannot be applied to operands of type 'type' and 'type'
    //}

    public static int UserCompare<T>(T a, T b) where T : IComparable<T> {
        return a.CompareTo(b);
    }
}