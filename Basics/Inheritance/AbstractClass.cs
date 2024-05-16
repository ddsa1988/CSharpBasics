namespace Basics.Inheritance;

public class AbstractClass {

    private abstract class Asset {
        public abstract string Name { get; set; }

        public abstract int Sum(int a, int b);

        public override string ToString() {
            return "Name: " + Name;
        }
    }

    private class House : Asset {
        public override string Name { get; set; } = string.Empty;

        public override int Sum(int a, int b) => a + b;

        public override string ToString() {
            return base.ToString();
        }
    }

    public static void UserMain() {
        House house = new House() { Name = "My house" };
        Console.WriteLine(house);
        Console.WriteLine(house.Sum(10, 20));

        //Asset asset = new Asset(); //Error => Cannot create an instance of the abstract class
    }
}