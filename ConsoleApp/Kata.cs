/// <summary>
/// https://www.codewars.com/kata/remove-first-and-last-character/train/csharp
/// </summary>
public class Kata
{
    public static string Remove_char(string s)
    {
        return s.Substring(1, s.Length - 1).Substring(0, s.Length - 2);
    }
}