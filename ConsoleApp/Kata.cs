using System;

/// <summary>
/// https://www.codewars.com/kata/ones-and-zeros/train/csharp
/// </summary>
public static class Kata
{
    public static int binaryArrayToNumber(int[] binaryArray)
    {
        var str = string.Concat(binaryArray);
        return Convert.ToInt32(str, 2);
    }
}