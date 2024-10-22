using Basics.Classes.Enums;
using Basics.Classes.Structs;

namespace Basics.Classes.Models;

public class PhoneScreen {
    public PhoneSize Size { get; set; }
    public ColorRgb Color { get; set; }

    public PhoneScreen() : this(PhoneSize.Small, new ColorRgb(0, 0, 0)) { }

    public PhoneScreen(PhoneSize size, ColorRgb color) {
        Size = size;
        Color = color;
    }
}