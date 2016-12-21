using System;

/// <summary>
/// https://www.codewars.com/kata/calculate-meal-total/train/csharp
/// </summary>
public class Kata
{
    public static double CalculateTotal(double subtotal, int tax, int tip)
    {
        return Math.Round(subtotal * (1 + (tax + tip) / 100.0), 2);
    }
}