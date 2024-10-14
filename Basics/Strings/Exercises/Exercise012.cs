using System.Text.RegularExpressions;

namespace Basics.Strings.Exercises;

public class Exercise012 {
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

        Regex regex = new Regex(@"^(http[s]?)(://)([w]{3}\.[a-z]+\.com)(/[A-z]+)");

        Console.WriteLine(regex.IsMatch(sample));
        Match matches = regex.Match(sample);

        foreach (var group in matches.Groups) {
            Console.WriteLine(group);
        }
    }
}