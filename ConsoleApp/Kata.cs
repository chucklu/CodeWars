using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/enumerable-magic-number-4-true-for-none/train/csharp
/// </summary>
public class Kata
{
    public static bool None(int[] arr, Func<int, bool> fun)
    {
        return !arr.Any(fun);
    }
}