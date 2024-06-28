using UsingAPI.Models;

namespace UsingAPI.Exercises;

public class Exercise003 {
    public static void UserMain() {
        List<Product> products = new List<Product>() {
            {new Product(){Name = "Test1", Price = 100.0}},
            {new Product(){Name = "Test2", Price = 200.0}},
            {new Product(){Name = "Test3", Price = 300.0}},
            {new Product(){Name = "Test4", Price = 400.0}},
            {new Product(){Name = "Test5", Price = 500.0}},
            {new Product(){Name = "Test6", Price = 600.0}},
            {new Product(){Name = "Test7", Price = 700.0}},
            {new Product(){Name = "Test8", Price = 800.0}},
            {new Product(){Name = "Test9", Price = 900.0}},
            {new Product(){Name = "Test10", Price = 1000.0}}
        };

        PrintCollection.Print(products, "\n");
    }
}