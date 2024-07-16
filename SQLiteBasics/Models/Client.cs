namespace SQLiteBasics.Models;

public class Client {
    private static int _id = 0;
    public string Name { get; init; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Id { get; }

    public Client() {
        Id = ++_id;
    }

    public override int GetHashCode() {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;

        try {
            Client other = (Client)obj;
            return Name.Equals(other.Name);
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        return false;
    }

    public override string ToString() {
        return "ID: " + Id +
               "\nName: " + Name +
               "\nEmail: " + Email;
    }
}