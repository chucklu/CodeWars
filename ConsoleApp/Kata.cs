using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/find-missing-numbers/train/csharp
/// </summary>
public class Kata
{
    public static int[] FindMissingNumbers(int[] arr)
    {
        if (arr.Length == 0)
        {
            return arr;
        }
        var fullArray = Enumerable.Range(arr[0], arr[arr.Length - 1] - arr[0] + 1).ToArray();
        return fullArray.Except(arr).ToArray();
    }
}