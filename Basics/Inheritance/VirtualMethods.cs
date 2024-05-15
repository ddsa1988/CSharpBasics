using System.Data;

namespace Basics.Inheritance;

public class VirtualMethods {

    private class Asset {
        public virtual long Number { get => 100; }

        public virtual string Text() => "Parent class";

        public virtual Asset Clone() => new Asset();
    }

    private class House : Asset {
        public override long Number { get => 2000; }

        public override string Text() => "Children class";

        public override House Clone() => new House();

        /*
         This is permitted because it does not break the contract that Clone must return an
         Asset: it returns a House, which is an Asset (and more).
         */
    }

    public static void UserMain() {
        Asset asset = new Asset();
        House house = new House();

        Console.WriteLine("Object from: " + asset.Text());
        Console.WriteLine("asset.Number: " + asset.Number);

        Console.WriteLine();

        Console.WriteLine("Object from: " + house.Text());
        Console.WriteLine("house.Number: " + house.Number);
    }
}

