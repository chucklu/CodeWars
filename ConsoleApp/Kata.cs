using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Kata
    {
        /// <summary>
        /// https://www.codewars.com/kata/reversing-words-in-a-string/train/csharp
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Reverse(string text)
        {
            return string.Join(" ", text.Split(' ').Reverse());
        }
    }
}
