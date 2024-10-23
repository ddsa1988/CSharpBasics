using Basics.Classes.Models;

namespace Basics.Classes.Exercises;

public class Exercise002 {
    public static void UserMain() {
        Book b1 = new Book("Book 1", "Diego", "Publisher", DateTime.Now, 12345);
        Book b2 = new Book("Book 2", "Amanda", "Publisher", DateTime.Now, 12345);

        Library library = new Library("My Library");
        library.AddBook(b1);
        library.AddBook(b2);

        Console.WriteLine(library.GetBookByAuthor("Amanda") + "\n");
        Console.WriteLine(library.GetBookByTitle("Book 1") + "\n");

        Console.WriteLine(library);

        Console.WriteLine(library.RemoveBookByTitle("Book 1"));

        Console.WriteLine(library);
    }
}