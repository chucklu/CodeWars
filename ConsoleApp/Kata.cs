using System.Linq;

namespace Solution
{
    /// <summary>
    /// https://www.codewars.com/kata/string-repeat/train/csharp
    /// </summary>
    public static class Program
    {
        public static string repeatStr(int n, string s)
        {
            return string.Join(string.Empty, Enumerable.Repeat(s, n));
        }
    }
}