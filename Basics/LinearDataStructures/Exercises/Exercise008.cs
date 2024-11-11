namespace Basics.LinearDataStructures.Exercises;

public class Exercise008 {
    // The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    // Write a program that finds the majorant of given array and prints it.If it does not exist, print "The majorant does not exist!".
    // Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3
    public static void UserMain() {
        var sourceList = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

        PrintMajorante(sourceList);
    }

    private static void PrintMajorante(List<int> list) {
        if (list.Count == 0) return;

        int listLength = list.Count;
        int minCount = listLength / 2 + 1;
        int lastValue = list[0];
        int bestCount = 1;

        list.Sort();

        for (int i = 1; i < listLength; i++) {
            int actualValue = list[i];

            if (bestCount >= minCount) break;

            if (actualValue == lastValue) {
                bestCount++;
                lastValue = actualValue;
                continue;
            }

            bestCount = 1;
            lastValue = actualValue;
        }

        if (bestCount >= minCount) {
            Console.WriteLine("Majorant: {0}.", lastValue);
        } else {
            Console.WriteLine("The majorant does not exist!");
        }
    }
}