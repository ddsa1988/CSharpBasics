using Microsoft.Data.Sqlite;
using Basics.SQLite.Models;

namespace Basics.SQLite.Examples;

public class Example003 {
    // Inserting data
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";
        string connectionString = $"Data Source={filePath}";

        InsertData(connectionString, new Person("Diego", new DateTime(1988, 01, 22)));
        InsertData(connectionString, new Person("Amanda", new DateTime(1993, 10, 16)));
    }

    private static void InsertData(string connectionString, Person person) {
        const string sql = "INSERT INTO Person (full_name, birthday) VALUES (@full_name, @birthday)";

        try {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("@full_name", person.Name);
            command.Parameters.AddWithValue("@birthday", person.Birthday);

            Console.WriteLine("Data inserted.");
        } catch (SqliteException e) {
            Console.WriteLine(e.Message);
        }
    }
}