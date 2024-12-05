using Microsoft.Data.Sqlite;

namespace Basics.SQLite.Examples;

public class Example007 {
    // Deleting data
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";
        string connectionString = $"Data Source={filePath}";
        const int id = 2;

        DeleteData(connectionString, id);
    }

    private static void DeleteData(string connectionString, int id) {
        const string sql = "DELETE FROM Person WHERE id = @id";

        try {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);

            int rowDeleted = command.ExecuteNonQuery();
            string text = rowDeleted > 0 ? "deleted" : "not deleted";

            Console.WriteLine($"Person with id {id} was {text}.");
        } catch (SqliteException e) {
            Console.WriteLine(e.Message);
        }
    }
}