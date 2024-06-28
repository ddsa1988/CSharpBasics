using UsingAPI.Models;

namespace UsingAPI.Exercises;
public class Exercise002 {
    public static void UserMain() {
        List<Book> books = new List<Book>() {
            {new Book(){Title = "Book 1", Year = 2001}},
            {new Book(){Title = "Book 2", Year = 1988}},
            {new Book(){Title = "Book 3", Year = 1850}},
            {new Book(){Title = "Book 4", Year = 2010}},
            {new Book(){Title = "Book 5", Year = 2000}},
            {new Book(){Title = "Book 6", Year = 1995}},
            {new Book(){Title = "Book 7", Year = 1999}},
            {new Book(){Title = "Book 8", Year = 2020}},
            {new Book(){Title = "Book 9", Year = 1975}},
            {new Book(){Title = "Book 10", Year = 1950}},
        };

        IEnumerable<String> booksFiltered = books.Where((book => book.Year >= 2000)).Select((book => book.Title));

        PrintCollection.Print(booksFiltered, "");
    }
}
