using SQLiteBasics.Utils;

namespace SQLiteBasics;

public class Program {
    public static void Main(string[] args) {
        ManageDatabase.CreateTable();
        ManageDatabase.Insert("Diego");
        ManageDatabase.Insert("Amanda");

        //Client c1 = new Client() { Name = "Diego", Email = "diego@hotmail.com" };
        //Client c2 = new Client() { Name = "Amanda", Email = "amanda@hotmail.com" };
        //Console.WriteLine(c1);
        //Console.WriteLine();
        //Console.WriteLine(c2);
    }
}