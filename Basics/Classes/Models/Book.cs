namespace Basics.Classes.Models;

public class Book {
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public long IsbnNumber { get; set; }

    public Book(string title, string author, string publisher, DateTime releaseDate, long isbnNumber) {
        Title = title;
        Author = author;
        Publisher = publisher;
        ReleaseDate = releaseDate;
        IsbnNumber = isbnNumber;
    }

    public override string ToString() {
        return "Title: " + Title + ", " +
               "Author: " + Author + ", " +
               "Publisher: " + Publisher + ", " +
               "Release Date:" + ReleaseDate + ", " +
               "ISBN-Number: " + IsbnNumber;
    }
}