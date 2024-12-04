using Microsoft.Data.Sqlite;

namespace Basics.SQLite.Examples;

public class Example007 {
    // Deleting data
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";
        string connectionString = $"Data Source={filePath}";

        DeleteData(connectionString);
    }

    private static void DeleteData(string connectionString) {
        const string sql = "DELETE FROM Person WHERE id = @id";
        const int id = 3;
    }
}