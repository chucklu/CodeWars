using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/equalize-the-array/train/csharp
/// </summary>
public static class Kata
{
    public static string[] Equalize(int[] array)
    {
        if (array.Length == 0)
        {
            return new string[] { };
        }
        return array.Select(x => Convert(x - array[0])).ToArray();
    }

    private static string Convert(int n)
    {
        if (n < 0)
        {
            return $"{n}";
        }
        return $"+{n}";
    }
}