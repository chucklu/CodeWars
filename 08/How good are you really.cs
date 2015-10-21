//http://www.codewars.com/kata/how-good-are-you-really
using System;
using System.Linq;

public class Kata
{
    public static bool BetterThanAverage(int[] classPoints, int myPoints)
    {
         return classPoints.Average() < myPoints;
    }
}