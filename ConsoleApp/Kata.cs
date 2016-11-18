using System;

/// <summary>
/// https://www.codewars.com/kata/keep-hydrated-1/train/csharp
/// </summary>
public class Kata
{
    private const double LitresPerHour = 0.5;

    public static int Litres(double time)
    {
        double total = time * LitresPerHour;
        int result = Convert.ToInt32(Math.Floor(total));
        return result;
    }
}