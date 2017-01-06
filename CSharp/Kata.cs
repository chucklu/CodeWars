using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/how-many-stairs-will-suzuki-climb-in-20-years/train/csharp
/// </summary>
public class Kata
{
    public static long StairsIn20(int[][] stairs)
    {
        long sum = 0;
        foreach (var item in stairs)
        {
            sum = sum + item.Sum();
        }
        return sum * 20;
    }
}