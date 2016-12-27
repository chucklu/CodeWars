using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/only-one/train/csharp
/// </summary>
public class Kata
{
    public static bool OnlyOne(params bool[] flags)
    {
        if (flags.Length == 0)
        {
            return false;
        }
        int count = flags.Where(x => x).Count();
        return count == 1;
    }
}