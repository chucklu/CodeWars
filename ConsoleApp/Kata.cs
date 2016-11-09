using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/zip-it/train/csharp
/// </summary>
public static class Kata
{
    public static object[] ZipIt(this object[] a, object[] b, Func<object, object, object> fn)
    {
        if (a.Length > b.Length)
        {
            a = a.Take(b.Length).ToArray();
        }
        else if (a.Length < b.Length)
        {
            b = b.Take(a.Length).ToArray();
        }
        return a.Select((t, i) => fn(t, b[i])).ToArray();
    }
}