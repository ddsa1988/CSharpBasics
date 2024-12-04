using Microsoft.Data.Sqlite;

namespace Basics.SQLite.Examples;

public class Example006 {
    // Selecting a scalar value
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";
        string connectionString = $"Data Source={filePath}";

        SelectData(connectionString);
    }

    private static void SelectData(string connectionString) {
        const string sql = "SELECT COUNT(*) FROM Person";

        try {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand(sql, connection);
            object? personCount = command.ExecuteScalar();

            Console.WriteLine($"The number of person database is {personCount}.");
        } catch (SqliteException e) {
            Console.WriteLine(e.Message);
        }
    }
}