using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/find-the-stray-number/train/csharp
/// </summary>
public class Kata
{
    public static int Stray(int[] numbers)
    {
        int first = numbers.First();
        var count = numbers.Count(x => x == first);
        if (count >= 2)
        {
            return numbers.Where(x => x != first).First();
        }
        return first;
    }
}