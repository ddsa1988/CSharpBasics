using Microsoft.Data.Sqlite;

namespace Basics.SQLite.Examples;

public class Example002 {
    // Creating tables
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";
        string connectionString = $"Data Source={filePath}";

        CreateTable(connectionString);
    }

    private static void CreateTable(string connectionString) {
        const string sql = """
                           CREATE TABLE IF NOT EXISTS Person (
                               id INTEGER PRIMARY KEY AUTOINCREMENT,
                               full_name VARCHAR(50) NOT NULL,
                               birthday DATETIME NOT NULL
                           );
                           """;

        try {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();

            Console.WriteLine("Table created.");
        } catch (SqliteException e) {
            Console.WriteLine(e.Message);
        }
    }
}