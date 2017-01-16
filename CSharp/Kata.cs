using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/unflatten-a-list-easy/train/csharp
/// </summary>
public class Kata
{
    public static object[] Unflatten(int[] flatArray)
    {
        var list = new List<object>();
        while (flatArray.Length > 0)
        {
            var temp = flatArray[0];
            if (temp >= 3)
            {
                list.Add(flatArray.Take(temp).ToArray());
                flatArray = flatArray.Skip(temp).ToArray();
            }
            else
            {
                list.Add(flatArray.Take(1).First());
                flatArray = flatArray.Skip(1).ToArray();
            }
        }
        return list.ToArray();
    }
}

