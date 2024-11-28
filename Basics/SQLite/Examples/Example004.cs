using Microsoft.Data.Sqlite;
using Basics.SQLite.Models;

namespace Basics.SQLite.Examples;

public class Example004 {
    // Selecting data
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";
        string connectionString = $"Data Source={filePath}";

        SelectData(connectionString);
    }

    private static void SelectData(string connectionString) {
        const string sql = "SELECT * FROM Person";

        try {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand(sql, connection);
            using SqliteDataReader reader = command.ExecuteReader();

            if (reader.HasRows) {
                Console.WriteLine("Rows: " + reader);
            }
        } catch (SqliteException e) {
            Console.WriteLine(e.Message);
        }
    }
}