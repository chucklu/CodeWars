using System;
using System.Linq;

/// <summary>
/// http://www.codewars.com/kata/enumerable-magic-number-1-true-for-all/train/csharp
/// </summary>
public class Kata
{
    public static bool All(int[] arr, Func<int, bool> fun)
    {
        return !arr.Any(x => fun(x) == false);
    }
}