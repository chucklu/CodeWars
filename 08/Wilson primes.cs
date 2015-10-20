///http://www.codewars.com/kata/wilson-primes/csharp
/// Wilson primes satisfy the following condition. Let P represent a prime number.
/// Then ((P-1)! + 1) / (P * P) should give a whole number.
/// Your task is to create a function that returns true if the given number is a Wilson prime.
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