namespace Basics.Classes.Structs;

public struct ColorRgb {
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }

    public ColorRgb() : this(0, 0, 0) { }

    public ColorRgb(byte red, byte green, byte blue) {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public override string ToString() {
        return $"Color Rgb({Red},{Green},{Blue})";
    }
}