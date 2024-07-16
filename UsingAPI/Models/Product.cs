namespace UsingAPI.Models;

public class Product {
    private double _price;
    public string Name { get; set; } = string.Empty;

    public double Price {
        get => _price;
        set {
            _price = value > 0 ? value : _price;
        }
    }

    public override string ToString() {
        return "Name: " + Name +
               "\nPrice: " + Price;
    }
}
