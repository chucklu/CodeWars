using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/sort-array-by-string-length/train/csharp
/// </summary>
public class Kata
{
    public static string[] SortByLength(string[] array)
    {
        return array.OrderBy(x => x.Length).ToArray();
    }
}