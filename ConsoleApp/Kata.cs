
/// <summary>
/// https://www.codewars.com/kata/heads-and-legs/train/csharp
/// </summary>
public class Kata
{
    public static object Animals(int heads, int legs)
    {
        if (heads == 0 && legs == 0)
        {
            return new[] { 0, 0 };
        }
        if (heads <= 0 || legs <= 0)
        {
            return "No solutions";
        }
        if (legs % 2 != 0)
        {
            return "No solutions";
        }
        var chickenCount = 2 * heads - legs / 2;
        var rabbitCount = legs / 2 - heads;
        if (chickenCount < 0)
        {
            return "No solutions";
        }
        if (rabbitCount < 0)
        {
            return "No solutions";
        }
        return new[] { chickenCount, rabbitCount };
    }
}

