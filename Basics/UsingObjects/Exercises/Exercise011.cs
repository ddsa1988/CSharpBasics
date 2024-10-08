namespace Basics.UsingObjects.Exercises;

public class Exercise011 {
    // Write a program, which generates a random advertising message for some product. 
    // The message has to consist of laudatory phrase, followed by a laudatory story, 
    // followed by author (first and last name) and city, which are selected from predefined lists.
    public static void UserMain() {
        string[] phrases = [
            "The product is excellent.",
            "This is a great product.",
            "I use this product constantly.",
            "This is the best product from this category."
        ];

        string[] stories = [
            "Now I feel better.",
            "I managed to change.",
            "It made some miracle.",
            "I can’t believe it, but now I am feeling great.",
            "You should try it, too. I am very satisfied."
        ];

        string[] firstName = ["Dayan", "Stella", "Hellen", "Kate"];

        string[] lastName = ["Johnson", "Peterson", "Raven"];

        string[] cities = ["London", "Paris", "Berlin", "New York", "Madrid"];

        string phrase = GetRandomText(phrases);
        string story = GetRandomText(stories);
        string fname = GetRandomText(firstName);
        string lname = GetRandomText(lastName);
        string city = GetRandomText(cities);

        Console.WriteLine($"{phrase} {story} -- {fname} {lname}, {city}.");
    }

    private static string GetRandomText(string[] texts) {
        if (texts == null || texts.Length == 0) throw new ArgumentException("Array is empty.", nameof(texts));

        int size = texts.Length;
        int randomNumber = GetRandomNumber(0, size);

        return texts[randomNumber];
    }

    private static int GetRandomNumber(int start, int end) {
        Random random = new Random();

        return random.Next(start, end);
    }
}