using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/sum-of-numbers-from-0-to-n/train/csharp
/// </summary>
public class Kata
{
    public static string ShowSequence(int n)
    {
        if (n < 0)
        {
            return $"{n}<0";
        }
        if (n == 0)
        {
            return "0=0";
        }
        return string.Join("+", Enumerable.Range(0, n + 1)) + $" = {n * (n + 1) / 2}";
    }
}