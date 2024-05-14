namespace Basics.Inheritance;

public class Upcasting {
    public static void UserMain() {
        Stock stock = new Stock("My stock", 1000);
        Asset asset = stock;

        Console.WriteLine("""
                          Stock stock = new Stock("My stock", 1000);
                          Asset asset = stock;
                          """ + "\n");
        
        Console.WriteLine("stock => " + stock + "\n");
        
        Console.WriteLine("asset => " + asset + "\n");
        
        Console.WriteLine("asset == stock: " + stock.Equals(asset));
        Console.WriteLine($"asset is Asset: {asset is Asset}");
        Console.WriteLine($"asset is Stock: {asset is Stock}");
        Console.WriteLine("asset type: " + asset.GetType().Name);
        Console.WriteLine("stock type: " + stock.GetType().Name);
    }
}

