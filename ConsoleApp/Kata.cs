using System.Collections.Generic;

/// <summary>
/// https://www.codewars.com/kata/initialize-my-name/train/csharp
/// </summary>
public class Kata
{
    public static string InitializeNames(string name)
    {
        var array = name.Split(' ');
        int index = 0;
        var list = new List<string>();
        foreach (var item in array)
        {
            index++;
            if (index == 1 || index == array.Length)
            {
                list.Add(item);
            }
            else
            {
                list.Add(item.Substring(0, 1) + ".");
            }
        }
        return string.Join(" ", list);
    }
}