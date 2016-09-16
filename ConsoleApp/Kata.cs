using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/enumerable-magic-number-2-true-for-any/train/csharp
/// </summary>
public class Kata
{
    public static bool Any(int[] arr, Func<int, bool> fun)
    {
        return arr.Any(fun);
    }
}