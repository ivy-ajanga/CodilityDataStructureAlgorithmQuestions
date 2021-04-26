using System;
using System.Collections.Generic;
public class Solution
{
    static void Main()
    {
       //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit."; //ball
       // string[] banned = { "hit" };
       string paragraph = "a, a, a, a, b,b,b,c, c"; //b
        string[] banned = { "a" };
        Console.WriteLine(MostCommonWord(paragraph, banned)); 
    }
    public static string MostCommonWord(string paragraph, string[] banned)
    {
        //add all banned words to a set
        HashSet<string> set = new HashSet<string>(banned);

        //replace all punctuations with space
        //split all words in string with space
        //convert all words in string to lowercase
        var words = paragraph.Replace("!", "")
                                .Replace("?", "")
                                .Replace("'", "")
                                .Replace(",", "")
                                .Replace(";", "")
                                .Replace(".", "")
                                .ToLower()
                                .Split(' ');
        //check if word in string is not banned add to dictionary
        // check for the max word as you add to dictionary and return it
        var maxWord = "";
        var maxCount = 0;
        Dictionary<string, int> CountofWords = new Dictionary<string, int>();
        foreach (var item in words)
        {
            if (set.Contains(item)) continue;
            if (!CountofWords.ContainsKey(item)) CountofWords.Add(item, 1);
            else
            {
                CountofWords[item]++;
            }
            if (maxCount <= CountofWords[item])
            {
                maxCount = CountofWords[item];
                maxWord = item;
            }
        }
        return maxWord;
    }
}