//http://www.codewars.com/kata/get-the-mean-of-an-array
using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
    return Convert.ToInt32(Math.Floor(marks.Average()));
  }
}