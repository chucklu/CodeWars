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
        /// https://www.codewars.com/kata/correct-the-mistakes-of-the-character-recognition-software/train/csharp
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Correct(string text)
        {
            return text.Replace("5", "S").Replace("1", "I").Replace("0", "O");
        }
    }
}
