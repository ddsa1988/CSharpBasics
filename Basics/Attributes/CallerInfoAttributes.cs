using System.Runtime.CompilerServices;

namespace Basics.Attributes;

public class CallerInfoAttributes {
    public static void UserMain() {
        Test();
    }

    private static void Test([CallerMemberName] string? memberName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0) {
        Console.WriteLine(memberName);
        Console.WriteLine(filePath);
        Console.WriteLine(lineNumber);
    }
}