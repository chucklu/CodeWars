using System;

/// <summary>
/// https://www.codewars.com/kata/sum-of-two-lowest-positive-integers/train/csharp
/// </summary>
public class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        Array.Sort(numbers);
        return numbers[0] + numbers[1];
    }
}