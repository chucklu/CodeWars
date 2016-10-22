using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/remove-duplicates-from-list/train/csharp
/// </summary>
public static class Kata
{
    public static int[] distinct(int[] a)
    {
        return  a.Distinct().ToArray();
    }
}
