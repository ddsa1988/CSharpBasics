namespace Basics.Strings.Exercises;

public class Exercise008 {
    /*
        Write a program that encrypts a text by applying XOR (excluding or) operation between the given source characters and given cipher code.
        The encryption should be done by applying XOR between the first letter of the text and the first letter of the code, the second letter of 
        the text and the second letter of the code, etc. until the last letter of the code, then goes back to the first letter of the code and 
        the next letter of the text. Print the result as a series of Unicode escape characters \xxxx.
        
        Sample source text: "Test". Sample cipher code: "ab". The result should be the following: "\u0035\u0007\u0012\u0016".
    */
    public static void UserMain() {
        string sampleText = "Test";
        string sampleCode = "ab";

        string[] unicodeSequence = GetEncryptedText(sampleText, sampleCode);

        foreach (string unicode in unicodeSequence) {
            Console.Write(unicode);
        }

        Console.WriteLine();
    }

    private static string[] GetEncryptedText(string text, string cipherCode) {
        if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) {
            throw new ArgumentException("Value is empty", nameof(text));
        }

        if (string.IsNullOrEmpty(cipherCode) || string.IsNullOrWhiteSpace(cipherCode)) {
            throw new ArgumentException("Value is empty", nameof(cipherCode));
        }

        const string unicodeSpecialChar = @"\u";

        int textLength = text.Length;
        int cipherCodeLength = cipherCode.Length;
        int cipherCodeIndex = 0;
        string[] unicodeSequence = new string[textLength];

        for (int i = 0; i < textLength; i++) {
            int textCharValue = (int)text[i];
            int cipherCodeCharValue = (int)cipherCode[cipherCodeIndex++];
            int encryption = textCharValue ^ cipherCodeCharValue;

            string unicode = $"{unicodeSpecialChar}{encryption:X4}";
            unicodeSequence[i] = unicode;

            if (cipherCodeIndex < cipherCodeLength) continue;

            cipherCodeIndex = 0;
        }

        return unicodeSequence;
    }
}