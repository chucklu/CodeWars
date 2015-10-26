//http://www.codewars.com/kata/filter-coffee
using System;
using System.Linq;

public class Kata
{
    public static string Search(int budget, int[] prices)
    {
        return string.Join(",", prices.Where(x => x <= budget).OrderBy(x => x));
    }
}