using Microsoft.Data.Sqlite;

namespace Basics.SQLite.Examples;

public class Example005 {
    // Selecting data with parameters
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";
        string connectionString = $"Data Source={filePath}";
        
        SelectData(connectionString);
    }

    private static void SelectData(string connectionString) {
        const string sql = "SELECT * FROM Person WHERE id = @id";
        const int personId = 1;

        try {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand(sql, connection);
            command.Parameters.AddWithValue("@id", personId);
            using SqliteDataReader reader = command.ExecuteReader();

            if (reader.HasRows) {
                while (reader.Read()) {
                    int id = reader.GetInt32(0);
                    string fullName = reader.GetString(1);
                    DateTime birthday = reader.GetDateTime(2);

                    Console.WriteLine($"{id}, {fullName}, {birthday}");
                }
            } else {
                Console.WriteLine("No data found");
            }
        } catch (SqliteException e) {
            Console.WriteLine(e.Message);
        }
    }
}