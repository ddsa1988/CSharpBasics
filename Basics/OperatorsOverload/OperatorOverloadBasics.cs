namespace Basics.OperatorOverload;

public class OperatorOverloadBasics {
    public static void UserMain() {
        Note n1 = new Note(10);
        Note n2 = n1 + 200;

        Console.WriteLine(n1.Value);
        Console.WriteLine(n2.Value);
    }

    private struct Note {
        public int Value { get; set; }

        public Note(int semiTonesFromA) {
            Value = semiTonesFromA;
        }

        public static Note operator +(Note x, int semiTones) {
            return new Note(x.Value + semiTones);
        }
    }
}

