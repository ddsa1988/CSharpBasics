using Basics.Principles_OOP.Models;

namespace Basics.Principles_OOP.Exercises;

public class Exercise003 {
    // Initialize an array of 10 workers and sort them by salary in descending order
    public static void UserMain() {
        Worker[] workers = [
            new Worker("Diego", "Alexandre", 600, 20),
            new Worker("Amanda", "Perna", 720, 20),
            new Worker("Rodrigo", "Santos", 550, 20),
            new Worker("Ivanice", "Ramos", 800, 20),
            new Worker("Tainara", "Alexandre", 530, 20),
        ];

        int length = workers.Length;

        for (int i = 0; i < length; i++) {
            for (int j = i + 1; j < length; j++) {
                Worker actual = workers[i];
                Worker next = workers[j];

                int result = actual.CompareTo(next);

                if (result >= 0) continue;

                Swap(ref workers[i], ref workers[j]);
            }
        }

        foreach (Worker worker in workers) {
            Console.WriteLine(worker + "\n");
        }
    }

    private static void Swap<T>(ref T obj1, ref T obj2) {
        (obj1, obj2) = (obj2, obj1);
    }
}