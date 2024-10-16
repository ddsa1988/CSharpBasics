using System.Text;

namespace Basics.Strings.Exercises;

public class Exercise020 {
    /*
        Write a program that extracts all the text without any tags and attribute values from an HTML document.
        
        Sample text:
        <html>
        <head><title>News</title></head>
        <body><p><a href="http://softuni.org">Software
        University</a>aims to provide free real-world practical
        training for young people who want to turn into
        skillful software engineers.</p></body>
        </html>
        
        Sample result:
        News
        Software University aims to provide free real-world
        practical training for young people who want to turn into
        skillful software engineers.
    */
    public static void UserMain() {
        string sample = """
        <html>
        <head><title>News</title></head>
        <body><p><a href="http://softuni.org">Software
        University</a> aims to provide free real-world practical
        training for young people who want to turn into
        skillful software engineers.</p></body>
        </html>
        """;

        Console.WriteLine(GetTextWithoutTags(sample));
    }

    private static string GetTextWithoutTags(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        const char openTag = '<';
        const char closeTag = '>';

        StringBuilder sb = new StringBuilder();
        bool tagOpened = false;

        foreach (char value in text) {
            if (value == openTag) {
                tagOpened = true;
                continue;
            }

            if (value == closeTag && tagOpened) {
                tagOpened = false;
                continue;
            }

            if (tagOpened) continue;

            sb.Append(value);
        }

        return sb.ToString();
    }
}