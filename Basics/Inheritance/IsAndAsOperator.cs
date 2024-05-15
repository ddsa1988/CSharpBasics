namespace Basics.Inheritance;

public class IsAndAsOperator {

    public static void UserMain() {
        Asset asset = new Asset("My asset");
        Stock stock = new Stock("My stock", 1000);

        Asset a = stock; //Upcast
        Stock? s = null;

        if (a is Stock) {
            s = a as Stock; //Downcast
        }

        Console.WriteLine("asset => " + asset + "\n");
        Console.WriteLine("stock => " + stock + "\n");
        Console.WriteLine("a => " + a + "\n");
        Console.WriteLine("s => " + s);
    }
}

