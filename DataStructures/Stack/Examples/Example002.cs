using System.Text;
using DataStructures.Stack.Models;

namespace DataStructures.Stack.Examples;

public class Example002 {
    // The base converter algorithm
    public static void UserMain() {
        Console.WriteLine(BaseConverter(8, 2));
        Console.WriteLine(BaseConverter(100345, 2));
        Console.WriteLine(BaseConverter(100345, 8));
        Console.WriteLine(BaseConverter(100345, 16));
    }

    private static string BaseConverter(int decimalNumber, int baseNumber) {
        const string digits = "0123456789ABCDEF";
        int[] baseNumbers = [2, 8, 16];
        var stack = new UserStack<int>();
        var sb = new StringBuilder();

        if (!baseNumbers.Contains(baseNumber)) {
            throw new ArgumentException("Base number must be in the range [{0}]", string.Join(", ", baseNumbers));
        }

        while (decimalNumber > 0) {
            if (stack.IsFull()) {
                stack.Resize(stack.Capacity * 2);
            }

            int remainder = decimalNumber % baseNumber;
            decimalNumber /= baseNumber;
            stack.Push(remainder);
        }

        while (!stack.IsEmpty()) {
            sb.Append(digits[stack.Pop()]);
        }

        return sb.ToString();
    }
}