using System.Collections.Generic;

/// <summary>
/// https://www.codewars.com/kata/printing-array-elements-with-comma-delimiters/train/csharp
/// </summary>
public class Kata
{
    public static string PrintArray(object[] array)
    {
        var list = new List<string>();
        foreach (var item in array)
        {
            var obj = item as object[];
            if (obj == null)
            {
                list.Add(item.ToString());
            }
            else
            {
                string temp = PrintArray(obj);
                list.Add(temp);
            }
        }
        return string.Join(",", list);
    }
}

