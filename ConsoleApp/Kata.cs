using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/all-inclusive/train/csharp
/// </summary>
public class Kata
{
    public static bool ContainAllRots(string temp, List<string> list)
    {
        if (temp.Equals(string.Empty))
        {
            return true;
        }
        var list1 = new List<string> { temp };
        for (int i = 1; i < temp.Length; i++)
        {
            var s = temp.Substring(i, temp.Length - i) + temp.Substring(0, i);
            list1.Add(s);
        }
        return !list1.Except(list).Any();
    }
}