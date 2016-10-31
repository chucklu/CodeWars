using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/sum-of-all-the-multiples-of-3-or-5/train/csharp
/// </summary>
public class Kata
{
    public static int findSum(int n)
    {
        return Enumerable.Range(3, n - 3 + 1).Where(x => x % 3 == 0 || x % 5 == 0).Aggregate(0, (current, item) => current + item);
    }
}