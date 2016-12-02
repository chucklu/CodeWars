using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/complete-the-pattern-number-4/train/csharp
/// </summary>
public class Kata
{
    public static string Pattern(int n)
    {
        if (n <= 0)
            return string.Empty;
        return string.Join("\n", Enumerable.Range(1, n).Select(i => string.Concat(Enumerable.Range(i, n - i + 1))));
    }
}