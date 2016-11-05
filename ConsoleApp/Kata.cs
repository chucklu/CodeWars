using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/correct-the-time-string/train/csharp
/// </summary>
public static class Time
{
    public static string Correct(string timeString)
    {
        if (string.IsNullOrEmpty(timeString))
        {
            return timeString;
        }
        var temp = timeString.Split(':');
        if (temp.Length != 3)
        {
            return null;
        }
        List<int> array;
        try
        {
            array = temp.Select(x => Convert.ToInt32(x)).ToList();
        }
        catch
        {
            return null;
        }

        DateTime time = DateTime.MinValue;
        time = time.AddHours(array[0]);
        time = time.AddMinutes(array[1]);
        time = time.AddSeconds(array[2]);
        string str = $"{time.Hour:D2}:{time.Minute:D2}:{time.Second:D2}";
        return str;
    }
}