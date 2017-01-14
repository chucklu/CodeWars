using System;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/moves-in-squared-strings-i/train/csharp
/// </summary>
public class Opstrings
{
    public static string VertMirror(string str)
    {
        var array = str.Split('\n');
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = string.Join(string.Empty, array[i].Reverse());
        }
        return string.Join("\n", array);
    }

    public static string HorMirror(string str)
    {
        var array = str.Split('\n');
        return string.Join("\n", array.Reverse());
    }

    public static string Oper(Func<string, string> fun, string str)
    {
        return fun(str);
    }
}
