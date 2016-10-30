using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/average-scores/train/csharp
/// </summary>
public class Kata
{
    public static int Average(int[] scores)
    {
        double average = scores.Average();
        return Convert.ToInt32(Math.Round(average, MidpointRounding.AwayFromZero));
    }
}