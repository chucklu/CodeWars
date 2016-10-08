using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/beginner-lost-without-a-map/train/csharp
/// </summary>
public class Kata
{
    public static int[] Maps(int[] x)
    {
        return x.Select(y => 2 * y).ToArray();
    }
}