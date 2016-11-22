using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/the-dropwhile-function/train/csharp
/// </summary>
public class Kata
{
    public static int[] DropWhile(int[] arr, Func<int, bool> pred)
    {
        var list = arr.ToList();
        var index = list.FindIndex(x => !pred(x));
        if (index == -1)
        {
            return new int[] { };
        }
        return list.Skip(index).Take(list.Count - index).ToArray();
    }
}