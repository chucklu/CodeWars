using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/pre-fizzbuzz-workout-number-1/train/csharp
/// </summary>
public class Kata
{
    public static int[] PreFizz(int n)
    {
        return Enumerable.Range(1, n).Select(x => x).ToArray();
    }
}