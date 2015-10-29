//http://www.codewars.com/kata/the-old-switcheroo-2
using System;
using System.Collections.Generic;

public class Kata
{
    public static string Encode(string str)
    {
        var dictionary = new Dictionary<char, int>();
        for (char c = 'a'; c <= 'z'; c++)
        {
            dictionary.Add(c, c - 'a' + 1);
        }
        for (char c = 'A'; c <= 'Z'; c++)
        {
            dictionary.Add(c, c - 'A' + 1);
        }
        string result = string.Empty;
        foreach (char c in str)
        {
            if (dictionary.ContainsKey(c))
            {
                result += dictionary[c];
            }
            else
            {
                result += c;
            }
        }
        return result;
    }
}