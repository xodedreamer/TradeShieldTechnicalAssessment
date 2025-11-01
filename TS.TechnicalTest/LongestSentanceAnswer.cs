
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        int maxWordCount = 0;
        //Charecters to expect at the end of the sentence.
        char[] sentenceDelimeters = new char[] { '.', '?', '!' };

        // Breaking the whole text into separate sentences.
        // StringSplitOptions.RemoveEmptyEntries ensures I don't get empty strings.
        string[] sentences = s.Split(sentenceDelimeters, StringSplitOptions.RemoveEmptyEntries);

        // Checking each sentence, one by one, to count the words.
        foreach (string sentence in sentences)
        {
            // Getting rid of any extra space at the beginning or end of the sentence
            // and then splitting it up by single space.
            string[] words = sentence.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int currentWordCount = words.Length;

            // Noting the count if the sentence is longer than previus sentence.
            if (currentWordCount > maxWordCount)
            {
                maxWordCount = currentWordCount;
            }
        }

        return maxWordCount;
    }
}
