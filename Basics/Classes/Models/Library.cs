using System.Text;

namespace Basics.Classes.Models;

public class Library {
    private List<Book> books;
    public string Name { get; set; }

    public Library(string name) {
        Name = name;
        books = new List<Book>();
    }

    public void AddBook(Book book) {
        books.Add(book);
    }

    public Book? GetBookByAuthor(string author) {

        foreach (Book book in books) {
            if (book.Author != author) continue;

            Book bookFound = book;
            return bookFound;
        }

        return null;
    }

    public Book? GetBookByTitle(string title) {

        foreach (Book book in books) {
            if (book.Title != title) continue;

            Book bookFound = book;
            return bookFound;
        }

        return null;
    }

    public Book? RemoveBookByTitle(string title) {

        int length = books.Count;
        int index = -1;

        for (int i = 0; i < length; i++) {
            if (books[i].Title != title) continue;

            index = i;
            break;
        }

        if (index == -1) return null;

        Book bookFound = books[index];
        books.RemoveAt(index);

        return bookFound;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();

        sb.Append($"Library: {Name}\n\n");

        if (books.Count > 0) {
            sb.Append("List of Books:\n");

            foreach (Book book in books) {
                sb.Append(book + "\n");
            }
        }

        return sb.ToString();
    }
}