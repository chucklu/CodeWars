//http://www.codewars.com/kata/number-of-people-in-the-bus/
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        return peopleListInOut.Sum(item => item[0] - item[1]);
    }
}