//http://www.codewars.com/kata/compoundarray
using System;
public class CompoundArrayClass
{
    public static int[] CompoundArray(int[] a, int[] b)
    {
        int length1 = a.Length;
        int length2 = b.Length;
        var array = new int[length1 + length2];
        int length = length1 > length2 ? length2 : length1;
        int index = 0;
        for (int i = 0; i < length; i++)
        {
            array[index] = a[i];
            array[index + 1] = b[i];
            index = index + 2;
        }
        if (a.Length == length)
        {
            for (int i = 0; i < Math.Abs(length1 - length2); i++)
            {
                array[index] = b[length + i];
                index++;
            }
        }
        else
        {
            for (int i = 0; i < Math.Abs(length1 - length2); i++)
            {
                array[index] = a[length + i];
                index++;
            }
        }
        return array;
    }
}