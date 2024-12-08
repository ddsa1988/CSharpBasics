namespace Basics.ProblemSolving.Models;

public class RandomNumber {
    public static int GetNextInt(int minValue, int maxValue) {
        var random = new Random();
        return random.Next(minValue, maxValue + 1);
    }
}

