using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace FileTask
{
    /* Please write a function that takes two parameters:
       the first parameter is a string that represents the name of a file
       the function should read the file and count each of the words inside the file
       the second parameter is a string that represents the name of a file
       the function should write all the words and its count (separated with spaces) 
        as new lines in the file in descending order based on the count
       You should handle the exceptions*/
    internal static class Program
    {
        private static void Main(string[] args)
        {

            WordsCountAndPrintIntoFile(@".\..\..\..\file01.txt", @".\..\..\..\file02.txt");
        }

        private static void WordsCountAndPrintIntoFile(string fileInput, string fileOutput)
        {
            try
            {
                var removedCharacters = new char[] { ' ', '.', '\n', ':', ',', '(', ')', '!', '?', ';', '"' };
                var allText = File.ReadAllText(fileInput);
                var lines = allText.Split(removedCharacters);
                var allWords = new List<string>();
                foreach (var line in lines)
                {
                    allWords.AddRange(line.Split());
                }

                var countWords = new Dictionary<string, int>();
                foreach (var word in allWords)
                {
                    if (countWords.ContainsKey(word))
                    {
                        countWords[word] += 1;
                    }
                    else
                    {
                        countWords.Add(word, 1);
                    }
                }

                var sortedWords = SortDictionary(countWords);
                var content = "";
                foreach (var (key, value) in sortedWords) 
                {
                    if (key != "")
                    {
                        content += key + " " + value + "\n";
                    }
                }

                File.WriteAllText(fileOutput, content);
                Console.WriteLine("Mision complete!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
        }

        private static Dictionary<string, int> SortDictionary(IDictionary<string, int> input)
        {
            var output = new Dictionary<string, int>();
            while (input.Count > 0)
            {
                var dictionaryList = new List<KeyValuePair<string,int>>();
                foreach (KeyValuePair<string, int> value in input)
                {
                    dictionaryList.Add(value);
                }
                var biggest = dictionaryList[0];
                for (int i = 1; i < dictionaryList.Count; i++)
                {
                    if (dictionaryList[i].Value >= biggest.Value)
                    {
                        biggest = dictionaryList[i];
                    }
                }
                input.Remove(biggest.Key);
                output.Add(biggest.Key, biggest.Value);
            }
            return output;
        }
    }
}


