using Microsoft.Data.Sqlite;

namespace Basics.SQLite.Examples;

public class Example001 {
    // Connecting to SQLite database
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";
        string connectionString = $"Data Source={filePath}";

        TestConnection(connectionString);
    }

    private static void TestConnection(string connectionString) {
        try {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            Console.WriteLine("Connection opened.");
        } catch (SqliteException e) {
            Console.WriteLine(e.Message);
        }
    }
}