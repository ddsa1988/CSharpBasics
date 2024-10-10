namespace Basics.ExceptionHandling.Models;

public class FileParseException : Exception {
    public FileParseException() { }

    public FileParseException(string message) : base(message) { }

    public FileParseException(string message, Exception inner) : base(message, inner) { }
}