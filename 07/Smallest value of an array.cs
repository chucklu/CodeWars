//http://www.codewars.com/kata/smallest-value-of-an-array
using System;
using System.Linq;

public class Kata
{
    public static int FindSmallest(int[] numbers, string toReturn)
    {
        int result = 0;
        if (toReturn.Equals("index"))
        {
            result = Array.IndexOf(numbers, numbers.Min());
        }
        else if (toReturn.Equals("value"))
        {
            result = numbers.Min();
        }
        return result;
    }
}