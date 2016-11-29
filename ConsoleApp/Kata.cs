using System.Collections.Generic;

/// <summary>
/// https://www.codewars.com/kata/replace-every-nth/train/csharp
/// </summary>
public class Kata
{
    public static string ReplaceNth(string text, int n, char oldValue, char newValue)
    {
        if (n <= 0 || n >= text.Length)
        {
            return text;
        }
        var list = new List<char>();
        int i = 0;
        foreach (var item in text)
        {
            if (item == oldValue)
            {
                i++;
                if (i == n)
                {
                    i = 0;
                    list.Add(newValue);
                }
                else
                {
                    list.Add(item);
                }
            }
            else
            {
                list.Add(item);
            }
        }
        return string.Concat(list);
    }
}