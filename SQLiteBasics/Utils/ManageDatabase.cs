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

            command.CommandText =
                "CREATE TABLE IF NOT EXISTS user(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL)";

            command.ExecuteNonQuery();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        } finally {
            Connection()?.Close();
        }
    }

    public static bool Insert(string name) {
        bool flag = false;

        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return flag;
        if (IsNameInDataBase(name)) return flag;

        try {
            SqliteCommand command = Connection().CreateCommand();
            command.CommandText = "INSERT INTO user (name) VALUES (@name)";
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();

            flag = true;
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        } finally {
            Connection()?.Close();
        }

        return flag;
    }

    private static bool IsNameInDataBase(string name) {
        bool flag = false;

        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return flag;

        try {
            SqliteCommand command = Connection().CreateCommand();
            command.CommandText = $"SELECT * FROM user WHERE name = '{name}'";

            using SqliteDataReader reader = command.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read()) {
                    int userId = reader.GetInt32(0);
                    string userName = reader.GetString(1);
                    // string userEmail = reader.GetString(2);

                    if (name != userName) continue;

                    flag = true;
                    break;
                }
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        } finally {
            Connection()?.Close();
        }

        return flag;
    }

    public static bool Delete(string name) {
        bool flag = false;

        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return flag;

        try {
            SqliteCommand command = Connection().CreateCommand();
            command.CommandText = "DELETE FROM user WHERE name = @name";
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();

            flag = true;
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        } finally {
            Connection()?.Close();
        }

        return flag;
    }
}