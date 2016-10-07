using System;

namespace Solution
{
    /// <summary>
    /// https://www.codewars.com/kata/bin-to-decimal/train/csharp
    /// </summary>
    public static class Program
    {
        public static int binToDec(string s)
        {
            return Convert.ToInt32(s, 2);
        }
    }
}