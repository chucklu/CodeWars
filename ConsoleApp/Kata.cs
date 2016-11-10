using System.Collections.Generic;

/// <summary>
/// https://www.codewars.com/kata/averages-of-numbers/train/csharp
/// </summary>
public class Kata
{
    public static double[] Averages(int[] numbers)
    {
        if (numbers == null || numbers.Length <= 1)
        {
            return new double[] { };
        }
        var list = new List<double>();
        for (int i = 1; i < numbers.Length; i++)
        {
            var temp = numbers[i - 1] + numbers[i];
            list.Add(temp/2.0);
        }
        return list.ToArray();
    }
}