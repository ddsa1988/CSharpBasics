namespace Basics.UsingObjects.Models;

public class Sequence {
    public static int CurrentValue { get; private set; } = 0;

    private Sequence() { } // Intentionally deny instantiation of this class

    public static int NextValue() {
        return ++CurrentValue;
    }
}