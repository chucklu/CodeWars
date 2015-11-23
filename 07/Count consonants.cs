//http://www.codewars.com/kata/count-consonants
using System;
using System.Linq;

public class Kata
{
  public static int ConsonantCount(string str)
  {
       return str.Where(c1 => "aeiou".IndexOf(c1) == -1).Count(c2 => char.IsLower(c2) || char.IsUpper(c2));
  }
}