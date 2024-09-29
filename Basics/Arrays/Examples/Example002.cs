namespace Basics.Arrays.Examples;

public class Example002 {
    public static void UserMain() {
        int[] n1 = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int[] n2 = [0, 1, 2, 3, 2, 1, 0];

        {
            bool isSimetric = true;
            int size = n1.Length / 2;

            for (int i = 0; i < size; i++) {
                int index = n1.Length - 1 - i;

                if (n1[i] != n1[index]) {
                    isSimetric = false;
                    break;
                }
            }

            Console.WriteLine($"Is the array 1 simetric? {isSimetric}.");
        }

        Console.WriteLine();

        {
            bool isSimetric = true;
            int size = n2.Length / 2;

            for (int i = 0; i < size; i++) {
                int index = n2.Length - 1 - i;

                if (n2[i] != n2[index]) {
                    isSimetric = false;
                    break;
                }
            }

            Console.WriteLine($"Is the array 2 simetric? {isSimetric}.");
        }
    }
}