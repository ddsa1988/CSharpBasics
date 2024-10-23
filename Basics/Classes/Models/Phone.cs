using Basics.Classes.Structs;

namespace Basics.Classes.Models;

public class Phone {
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public string? Owner { get; set; }
    public float Price { get; private set; }
    PhoneBattery? PhoneBattery { get; set; }
    ColorRgb ColorRgb { get; set; }

    public Phone(string model, string manufacturer, float price) {
        Model = model;
        Manufacturer = manufacturer;

        SetPrice(price);
    }

    public Phone(string model, string manufacturer, float price, string owner, PhoneBattery phoneBattery, ColorRgb colorRgb) : this(model, manufacturer, price) {
        Owner = owner;
        PhoneBattery = phoneBattery;
        ColorRgb = colorRgb;
    }

    public void SetPrice(float price) {
        if (price <= 0) {
            throw new ArgumentOutOfRangeException(nameof(price), "Parameter must be greater than zero.");
        }

        Price = price;
    }

    public override string ToString() {
        return $"Model: {Model},\nManufacture: {Manufacturer},\nOwner: {Owner},\nPrice: {Price:F2},\nPhone battery: {PhoneBattery},\nColor: {ColorRgb}";
    }
}