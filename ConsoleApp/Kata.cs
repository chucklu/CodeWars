using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/alternate-case/train/csharp
/// </summary>
public class Kata
{
    public static string alternateCase(string s)
    {
        return string.Concat(s.Select(Switch));
    }

    public static char Switch(char c)
    {
        if (char.IsLower(c))
        {
            return char.ToUpper(c);
        }
        return char.ToLower(c);
    }
}