using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/calculate-average/train/csharp
/// </summary>
public class Kata
{
    public static double FindAverage(double[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }
        return array.Average();
    }
}