//http://www.codewars.com/kata/excel-sheet-column-numbers
using System;
using System.Collections.Generic;
using System.Linq;

public class ExcelToNumber
{
    public static long TitleToNumber(string title)
    {
        var dictionary = new Dictionary<char, int>();
        for (int i = 65; i <= 90; i++)
        {
            dictionary.Add((char)i, i - 64);
        }
        var array = title.ToCharArray();
        Array.Reverse(array);
        title = new string(array);
        return title.Select((t, i) => dictionary[t] * (long)Math.Pow(26, i)).Sum();
    }
}