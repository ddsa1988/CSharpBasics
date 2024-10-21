using Basics.Enumerations.Enums;

namespace Basics.Enumerations.Models;

public class Coffee {
    public CoffeeSize Size { get; private set; }

    public Coffee(CoffeeSize size) {
        Size = size;
    }
}