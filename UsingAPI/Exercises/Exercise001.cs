using UsingAPI.Models;

namespace UsingAPI.Exercises;

public class Exercise001 {
    public static void UserMain() {
        Random random = new Random();
        List<int> numbers = new List<int>() { 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 6, 9, 10, 5 };

        IEnumerable<int> unique = numbers.Distinct();

        foreach(int number in unique) {
            Console.Write(number + " ");
        }
    }
}