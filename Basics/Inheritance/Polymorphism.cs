namespace Basics.Inheritance;

public class Polymorphism {
    public static void UserMain() {
        List<Asset> assets = [
            new Asset("My asset"),
            new Stock("My stock", 1000), //Upcast to the base clas
            new House("My house", 2000) //Upcast to the base class
        ];

        Display(assets);
    }

    private static void Display(List<Asset> assets) {
        foreach (Asset asset in assets) {
            Console.WriteLine("Type: " + asset.GetType().Name);
            Console.WriteLine(asset + "\n");
        }
    }
}