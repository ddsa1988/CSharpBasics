namespace Basics.NullableValueTypes;

public class BoxingUnboxingNullableValues {
    public static void UserMain() {
        {
            object obj = "string";
            int? x = obj as int?;

            Console.WriteLine(obj);
            Console.WriteLine(x.HasValue);
        }

        Console.WriteLine();

        {
            object obj = "100";
            int? x = obj as int?;

            Console.WriteLine(obj);
            Console.WriteLine(x.HasValue);
        }

        Console.WriteLine();

        {
            {
                object obj = 100;
                int? x = obj as int?;

                Console.WriteLine(obj);
                Console.WriteLine(x.HasValue);
            }
        }
    }
}