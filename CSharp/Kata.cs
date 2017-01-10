using System;

/// <summary>
/// https://www.codewars.com/kata/circle-area-inside-square/train/csharp
/// </summary>
public class Kata
{
    public static double SquareAreaToCircle(double size)
    {
        return Math.Round(Math.PI * size / 4.0, 8);
    }
}