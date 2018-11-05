using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class Amazon
    {
        public static List<String> retrieveMostFrequentlyUsedWords(String literatureText, List<String> wordsToExclude)
        {
            if (string.IsNullOrEmpty(literatureText))
                return new List<string>();

            var words = literatureText.Split(' ');
            var includedWords = words.Where(w => wordsToExclude == null || !wordsToExclude.Contains(w));

            if (includedWords.Count() == 0)
                return new List<string>();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (var word in includedWords)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }

            var max = wordCount.Max(wc => wc.Value);
            var maxWordCount = wordCount.Where(wc => wc.Value == max).Select(wc => wc.Key).ToList<string>();
           
            return maxWordCount;
        }

        public static List<string> reorderLines(int logFileSize, string[] logLines)
        {
            var wordLines = new List<string>();
            var numberLines = new List<string>();

            for (int i = 0; i < logFileSize; i++)
            {
                if (logLines.Length > i)
                {
                    var line = logLines[i];
                    var words = line.Split(' ');
                    var firstCharacter = words[1][0];

                    if (firstCharacter >= 'a' && firstCharacter <= 'z')
                        wordLines.Add(line);
                    else
                        numberLines.Add(line);
                }                
            }

            wordLines = wordLines.OrderBy(l => MoveIdentifierToLast(l)).ToList();

            wordLines.AddRange(numberLines);
            return wordLines;
        }

        public static string MoveIdentifierToLast(string line)
        {
            var words = line.Split(' ');
            var len = words.Length;

            var temp = words[0];

            for (int i = 0; i < len-1; i++)
            {
                words[i] = words[i + 1];
            }
            words[len - 1] = temp;

            return string.Join(" ", words);
        }
    }
}
