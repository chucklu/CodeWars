using System.Collections.Generic;

/// <summary>
/// https://www.codewars.com/kata/generate-range-of-integers/train/csharp
/// </summary>
public class Kata
{
    public static int[] GenerateRange(int min, int max, int step)
    {
        List<int> list = new List<int>();
        for (int i = min; i <= max; i = i + step)
        {
            list.Add(i);
        }
        return list.ToArray();
    }
}