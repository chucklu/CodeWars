using System;

/// <summary>
/// https://www.codewars.com/kata/unlucky-days/train/csharp
/// </summary>
public class Kata
{
    public static int UnluckyDays(int year)
    {
        int count = 0;
        for (int i = 1; i <= 12; i++)
        {
            var dateTime = new DateTime(year, i, 13);
            if (dateTime.DayOfWeek == DayOfWeek.Friday)
            {
                count++;
            }
        }
        return count;
    }
}