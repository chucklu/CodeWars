//http://www.codewars.com/kata/number-pairs
using System;
using System.Linq;

public class Kata
{
    public static int[] getLargerNumbers(int[] a, int[] b)
    {
        return a.Zip(b, (x, y) => x > y ? x : y).ToArray();
    }
}