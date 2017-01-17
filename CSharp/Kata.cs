using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/disemvowel-trolls/train/csharp
/// </summary>
public static class Kata
{
    public static string Disemvowel(string str)
    {
        return string.Join(string.Empty, str.Where(c => "aeiouAEIOU".IndexOf(c) == -1));
    }
}

