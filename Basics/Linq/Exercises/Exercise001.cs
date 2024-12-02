using System.Text;

namespace Basics.Linq.Exercises;

public class Exercise001 {
    // Implement an extension method Substring(int index, int length) for the class StringBuilder
    // that returns a new StringBuilder and has the same functionality as the method Substring(...) of the class String.
    public static void UserMain() {
        var sb = new StringBuilder();
        sb.AppendLine("Diego dos Santos Alexandre");
        
        Console.WriteLine(sb.Substring(0, 5));
    }
}

public static class StringBuilderExtensions {
    public static StringBuilder Substring(this StringBuilder builder, int startIndex, int length) {
        ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(startIndex, builder.Length);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(length);

        var sb = new StringBuilder();

        for (int i = startIndex; i < length; i++) {
            sb.Append(builder[i]);
        }

        return sb;
    }
}