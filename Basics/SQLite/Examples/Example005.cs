using Microsoft.Data.Sqlite;

namespace Basics.SQLite.Examples;

public class Example005 {
    // Selecting data with parameters
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";
        string connectionString = $"Data Source={filePath}";
    }
}