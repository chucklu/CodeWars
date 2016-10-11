using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/beginner-reduce-but-grow/train/csharp
/// </summary>
public class Kata
{
    public static int Grow(int[] x)
    {
        return x.Aggregate(1, (current, item) => current * item);
    }
}