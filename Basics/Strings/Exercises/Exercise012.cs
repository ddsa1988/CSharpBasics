using System.Text;
using System.Text.RegularExpressions;

namespace Basics.Strings.Exercises;

public partial class Exercise012 {
    /*
        Write a program that parses an URL in following format:
        [protocol]://[server]/[resource]
        It should extract from the URL the protocol, server and resource parts.
        
        For example, when http://www.cnn.com/video is passed, the result is:
        [protocol]="http"
        [server]="www.cnn.com"
        [resource]="/video"
    */
    public static void UserMain() {
        string sample = "http://www.cnn.com/video";

        Console.WriteLine(ExtractURL(sample));
    }

    private static string ExtractURL(string url) {
        if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url)) {
            throw new ArgumentException("Value is empty", nameof(url));
        }

        StringBuilder sb = new StringBuilder();

        Regex regex = MyRegex();
        Match matches = regex.Match(url);

        if (matches.Success) {
            sb.Append($"[protocol]=\"{matches.Groups[1]}\"\n");
            sb.Append($"[server]=\"{matches.Groups[3]}\"\n");
            sb.Append($"[resource]=\"{matches.Groups[4]}\"\n");
        }

        return sb.ToString();
    }

    [GeneratedRegex(@"^(http[s]?)(://)([w]{3}\.[a-z]+\.com)(/[A-z]+)")]
    private static partial Regex MyRegex();
}