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
        /// https://www.codewars.com/kata/grasshopper-summation/train/csharp
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int summation(int num)
        {
            int sum = (1 + num) * num / 2;
            return sum;
        }
    }
}
