using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/enumerable-magic-number-3-does-my-list-include-this/train/csharp
/// </summary>
public class Kata
{
    public static bool Include(int[] arr, int item)
    {
        return arr.Contains(item);
    }
}