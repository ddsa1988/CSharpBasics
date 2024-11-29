namespace Basics.Linq.Examples;

public class Example011 {
    // Joining data with Linq
    public static void UserMain() {
        var categories = new List<Category>() {
            new() { Id = 1, Name = "Fruit" },
            new() { Id = 2, Name = "Food" },
            new() { Id = 3, Name = "Shoe" },
            new() { Id = 4, Name = "Juice" }
        };

        var products = new List<Product>() {
            new() { Name = "Strawberry", CategoryId = 1 },
            new() { Name = "Banana", CategoryId = 1 },
            new() { Name = "Chicken meat", CategoryId = 2 },
            new() { Name = "Apple Juice", CategoryId = 4 },
            new() { Name = "Fish", CategoryId = 2 },
            new() { Name = "Orange Juice", CategoryId = 4 },
            new() { Name = "Sandal", CategoryId = 3 },
        };

        var productsWithCategory = from product in products
                                   join category in categories
                                   on product.CategoryId equals category.Id
                                   select new { Name = product.Name, Category = category.Name };

        foreach (var item in productsWithCategory) {
            Console.WriteLine(item);
        }
    }

    private class Product {
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
    }

    private class Category {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; }
    }
}