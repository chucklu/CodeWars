using System;
using System.Collections.Generic;

/// <summary>
/// http://www.codewars.com/kata/filtering-even-numbers-bug-fixes/csharp
/// </summary>
public class Kata
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
    {
        for (int i = listOfNumbers.Count - 1; i >= 0; i--)
        {
            if (listOfNumbers[i] % 2 == 0)
            {
                listOfNumbers.RemoveAt(i);
            }
        }
        return listOfNumbers;
    }
}