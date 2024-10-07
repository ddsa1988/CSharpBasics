namespace Basics.Recursion.Exercises;

public class Exercise001 {
    // Write a program that simulates the execution of N nested loops from 1 to K, where N and K are entered by the user.
    public static void UserMain() {
        int numberOfLoops = 2;
        int numberOfIterations = 3;
        int[] loops = new int[numberOfLoops];

        NestedLoops(0);

        void NestedLoops(int currentLoop) {
            if (currentLoop == numberOfLoops) {
                PrintLoops();
                return;
            }

            for (int i = 1; i <= numberOfIterations; i++) {
                loops[currentLoop] = i;

                NestedLoops(currentLoop + 1);
            }

        }

        void PrintLoops() {
            for (int i = 0; i < numberOfLoops; i++) {
                Console.Write($"{loops[i]} ");
            }

            Console.WriteLine();
        }
    }
}