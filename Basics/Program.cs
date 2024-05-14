namespace Basics;

public class Program {
    public static void Main(string[] args) {
        Asset asset = new Asset("Asset");
        Stock stock = new Stock("Stock", 500);
        House house = new House("House", 1000)
;
        Console.WriteLine(asset + "\n");
        Console.WriteLine(stock + "\n");
        Console.WriteLine(house + "\n");

        Console.WriteLine(asset is Asset);
        Console.WriteLine(stock is Asset);
        Console.WriteLine(house is Asset);

        Console.WriteLine(typeof(Asset).IsInstanceOfType(house));

    }
}