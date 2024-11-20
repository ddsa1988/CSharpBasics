namespace Basics.Principles_OOP.Models;

public class Rectangle : Shape {
    public Rectangle(float width, float height) {
        Width = width;
        Height = height;
    }
    public override float CalculateArea() {
        float area = Height * Width;

        return area;
    }

    public float Width {
        get => base.width;
        set => base.width = value > 0 ? value : 0;
    }

    public float Height {
        get => base.height;
        set => base.height = value > 0 ? value : 0;
    }
}