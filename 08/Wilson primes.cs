///http://www.codewars.com/kata/wilson-primes/csharp
using System;

public class Kata
{
        public static bool AmIWilson(int p)
        {
            int result = Factorial(p - 1) + 1;
            double square = Math.Pow(p, 2);
            return result % square == 0;
        }

        private static int Factorial(int p)
        {
            if (p == 0 || p == 1)
            {
                return 1;
            }
            return p*Factorial(p - 1);
        }
}