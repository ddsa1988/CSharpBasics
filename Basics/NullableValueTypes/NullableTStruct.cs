namespace Basics.NullableValueTypes;

public class NullableTStruct {
    public static void UserMain() {
        //int i = null; //Compile error, value cannot be null

        {
            int? i = null;
            Console.WriteLine(i == null);
        }

        Console.WriteLine();

        {
            Nullable<int> i = new Nullable<int>();
            Console.WriteLine(i.HasValue);
            Console.WriteLine(i.GetValueOrDefault(-1));

            if (i.HasValue) Console.WriteLine(i.Value); //Trying to retrive Value when HasValue is false throws an Invalid Operation Exception
        }

        Console.WriteLine();

        {
            Nullable<int> i = new Nullable<int>();
            i = 10;
            Console.WriteLine(i.HasValue);
            Console.WriteLine(i.GetValueOrDefault(-1));

            if (i.HasValue) Console.WriteLine(i.Value);
        }
    }
}