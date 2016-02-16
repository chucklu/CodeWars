using System;

public class Kata
{
    public static bool IsAscOrder(int[] arr)
    {
        bool flag = true;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                flag = false;
                break;
            }
        }
        return flag;
    }
}