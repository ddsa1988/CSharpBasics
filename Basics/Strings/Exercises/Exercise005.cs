using System.Text;

namespace Basics.Strings.Exercises;

public class Exercise005 {
    /*
    A text is given. Write a program that modifies the casing of letters to uppercase at all 
    places in the text surrounded by <upcase> and </upcase> tags. Tags cannot be nested.

    Example:
    We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
    
    Result:
    We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

    */
    public static void UserMain() {
        string sample = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        Console.WriteLine(ModifyTextCasing(sample));
    }

    private static string ModifyTextCasing(string text) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        StringBuilder sb = new StringBuilder();

        string openTag = "<upcase>";
        string closeTag = "</upcase>";

        int startIndex = 0;
        int indexOpenTag = -1;
        int indexCloseTag = -1;

        while (true) {
            indexOpenTag = text.IndexOf(openTag, indexOpenTag + 1);

            if (indexOpenTag == -1) {

                if (indexCloseTag != -1) {
                    int indexLastSubstring = indexCloseTag + closeTag.Length;
                    sb.Append(text.AsSpan(indexLastSubstring, text.Length - indexLastSubstring));
                }

                break;
            }

            indexCloseTag = text.IndexOf(closeTag, indexOpenTag + openTag.Length);

            if (indexCloseTag != -1 && startIndex < indexOpenTag) {
                int indexStartSubstring = indexOpenTag + openTag.Length;

                sb.Append(text.AsSpan(startIndex, indexOpenTag - startIndex));
                sb.Append(text.Substring(indexStartSubstring, indexCloseTag - indexStartSubstring).ToUpper());

                startIndex = indexCloseTag + closeTag.Length;
            } else {
                sb.Append(text.AsSpan(startIndex, text.Length - startIndex));
                break;
            }
        }

        return sb.ToString();
    }
}