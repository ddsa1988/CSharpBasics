namespace Basics.Classes.Examples;

public class Example002 {
    // The reserved word 'this' is used to reference the current object
    public static void UserMain() {
        WordThis test = new WordThis();
        Console.WriteLine(test);
        test.PrintThis();
    }

    private class WordThis {
        private string name = "Diego";
        private int id = 100;

        public void PrintThis() {
            Console.WriteLine(this);
        }

        public override string ToString() {
            return "Name: " + this.name + "\n" +
                   "Id: " + this.id;
        }
    }
}