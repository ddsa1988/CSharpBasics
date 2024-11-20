namespace Basics.Principles_OOP.Models;

public class Circle : Shape {
    private float radius;

    public Circle(float radius) {
        Radius = radius;
    }

    public override float CalculateArea() {
        double area = Math.PI * Math.Pow(Radius, 2);

        return (float)area;
    }

    public float Radius {
        get => radius;
        set {
            radius = value > 0 ? value : 0;
            base.width = radius;
            base.height = radius;
        }
    }
}