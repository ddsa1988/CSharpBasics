using Microsoft.Data.Sqlite;

namespace SQLiteBasics.Utils;

public class ManageDatabase {
    private static SqliteConnection Connection() {
        char sepChar = Path.DirectorySeparatorChar;
        string dir = $"..{sepChar}..{sepChar}..{sepChar}";
        string folderPath = $"{dir}Files";
        string filePath = $"{folderPath}{sepChar}";

        if (!Path.Exists(dir)) {
            throw new DirectoryNotFoundException();
        }

        if (!Directory.Exists(folderPath)) {
            Directory.CreateDirectory(folderPath);
        }

        var connection = new SqliteConnection($"Data Source={filePath}Clients.db");
        connection.Open();

        return connection;
    }

    public static void CreateTable() {
        try {
            SqliteCommand command = Connection().CreateCommand();

            command.CommandText = @"CREATE TABLE IF NOT EXISTS user(
                              id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                              name TEXT NOT NULL)";

            command.ExecuteNonQuery();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        } finally {
            Connection()?.Close();
        }
    }

    public static void Insert(string name) {
        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return;

        try {
            SqliteCommand command = Connection().CreateCommand();

            command.CommandText = @"INSERT INTO user (name) VALUES ($name)";
            command.Parameters.AddWithValue("$name", name);
            command.ExecuteNonQuery();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        } finally {
            Connection()?.Close();
        }
    }
}