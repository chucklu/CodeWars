using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/sorted-yes-no-how/train/csharp
/// </summary>
public class Kata
{
    public static string IsSortedAndHow(int[] array)
    {
        string result;
        var array1 = array.OrderBy(x => x).ToArray();
        var array2 = array.OrderByDescending(x => x).ToArray();
        if (array.SequenceEqual(array1))
        {
            result = "yes, ascending";
        }
        else if (array.SequenceEqual(array2))
        {
            result = "yes, descending";
        }
        else
        {
            result = "no";
        }
        return result;
    }
}