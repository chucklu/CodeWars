using System.Linq;
using System.Threading;

/// <summary>
/// https://www.codewars.com/kata/borrower-speak/train/csharp
/// </summary>
public static class Kata
{
    public static string Borrow(string s)
    {
        return string.Concat(s.Where(char.IsLetter).Select(char.ToLower));
    }
}