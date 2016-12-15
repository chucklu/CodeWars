using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/compare-strings-by-sum-of-chars/train/csharp
/// </summary>
public class Kata
{
    public static bool Compare(string s1, string s2)
    {
        if (string.IsNullOrEmpty(s1) || s1.All(char.IsLetter) == false)
        {
            s1 = string.Empty;
        }
        if (string.IsNullOrEmpty(s2) || s2.All(char.IsLetter) == false)
        {
            s2 = string.Empty;
        }
        int sum1 = s1.ToUpper().Sum(x => x);
        int sum2 = s2.ToUpper().Sum(x => x);
        return sum1 == sum2;
    }
} 