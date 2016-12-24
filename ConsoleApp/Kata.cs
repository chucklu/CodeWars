using System;

/// <summary>
/// https://www.codewars.com/kata/sort-numbers/train/csharp
/// </summary>
public class Kata
{
    public static int[] SortNumbers(int[] nums)
    {
        if (nums == null)
        {
            return new int[] { };
        }
        Array.Sort(nums);
        return nums;
    }
}