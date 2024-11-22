using Basics.SQLite.Models;
using Microsoft.Data.Sqlite;

namespace Basics.SQLite;

public class Example001 {
    public static void UserMain() {
        char sepChar = Path.DirectorySeparatorChar;
        string filePath = $"..{sepChar}..{sepChar}..{sepChar}SQLite{sepChar}DataBase{sepChar}Data.db";

        TestConnection(filePath);
    }

    private static void TestConnection(string filePath) {
        if (!File.Exists(filePath)) return;

        try {
            using var connection = new SqliteConnection($"Data Source={filePath}");
            connection.Open();

            Console.WriteLine("Connection opened.");
        } catch (SqliteException e) {
            Console.WriteLine(e.Message);
        }
    }
}