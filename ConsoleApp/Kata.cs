using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/shortest-word/train/csharp
/// </summary>
public class Kata
{
    public static int FindShort(string s)
    {
        return s.Split(' ').Min(x => x.Length);
    }
}