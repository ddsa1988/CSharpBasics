using UsingAPI.Examples;
using UsingAPI.Exercises;

namespace UsingAPI;

public class Program {
    public static void Main(string[] args) {
        Example006.UserMain();

        char sepChar = Path.DirectorySeparatorChar;

        Console.WriteLine(sepChar);
    }
}