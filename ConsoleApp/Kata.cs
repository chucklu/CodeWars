using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/the-dropwhile-function/train/csharp
/// </summary>
public class Kata
{
    public static int[] DropWhile(int[] arr, Func<int, bool> pred)
    {
        return arr.SkipWhile(pred).ToArray();
    }
}