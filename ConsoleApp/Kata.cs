using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/complete-series/train/csharp
/// </summary>
public class Kata
{
    public static int[] CompleteSeries(int[] arr)
    {
        int count = arr.GroupBy(x => x).Count();
        if (arr.Length > count)
        {
            return new[] { 0 };
        }
        int max = arr.Max();
        return Enumerable.Range(0, max + 1).ToArray();
    }
}