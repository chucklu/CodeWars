//http://www.codewars.com/kata/surrounding-primes-for-a-value
using System;
using System.Collections.Generic;

public class BeforeAfterPrimes
{

    public static long[] PrimeBefAft(long num)
    {
        var list = new List<long>();
        for (long i = num - 1; i >= 2; i--)
        {
            if (Prime(i))
            {
                list.Add(i);
                break;
            }
        }
        for (long i = num + 1; ; i++)
        {
            if (Prime(i))
            {
                list.Add(i);
                break;
            }
        }
        return list.ToArray();
    }

    public static bool Prime(long number)
    {
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}