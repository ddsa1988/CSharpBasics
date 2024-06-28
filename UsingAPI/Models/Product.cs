namespace UsingAPI.Models;

public class Product {
    private double price;
    public string Name { get; set; } = string.Empty;

    public double Price {
        get => price;
        set {
            price = value > 0 ? value : price;
        }
    }

    public override string ToString() {
        return "Name: " + Name +
               "\nPrice: " + Price;
    }
}
