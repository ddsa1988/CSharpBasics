namespace Basics.Generics;

public class GenericDefaultValue {
    public static void UserMain() {
        Console.WriteLine("int default value: " + GetGenericDefaultValue<int>());
        Console.WriteLine("float default value: " + GetGenericDefaultValue<float>());
        Console.WriteLine("string default value: " + (GetGenericDefaultValue<string>()?.ToString() ?? "null"));
        Console.WriteLine("Person object default value: " + (GetGenericDefaultValue<Person>()?.ToString() ?? "null"));
    }

    public static T? GetGenericDefaultValue<T>() {
        //return default(T);
        return default;
    }

    public class Person {
        public string Name { get; set; } = string.Empty;
    }
}