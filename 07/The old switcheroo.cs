//http://www.codewars.com/kata/the-old-switcheroo
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string Vowel2Index(string str)
    {
        const string vowels = "aeiou";
        var list = new List<string>();
        int index = 0;
        foreach (var c in str)
        {
            index++;
            if (vowels.Contains(c))
            {
                list.Add(index.ToString());
            }
            else
            {
                list.Add(c.ToString());
            }
        }
        return string.Join(string.Empty, list);
    }
}