using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/to-square-root-or-not-to-square-root/train/csharp
/// </summary>
public class Kata
{
    public static int[] SquareOrSquareRoot(int[] array)
    {
        return array.Select(Fun).ToArray();
    }

    public static int Fun(int input)
    {
        double k = Math.Sqrt(input);
        int n = Convert.ToInt32(Math.Ceiling(k));
        int s = n * n;
        if (s == input)
        {
            return n;
        }
        else
        {
            return input * input;
        }
    }
}