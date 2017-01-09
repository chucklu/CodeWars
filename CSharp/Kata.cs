using System;

/// <summary>
/// https://www.codewars.com/kata/binary-operations-number-1/train/csharp
/// </summary>
public class Kata
{
    public static int FlipBit(int value, int bitIndex)
    {
        string str = Convert.ToString(value, 2).PadLeft(32, '0');
        var array = str.ToCharArray();
        int index = 32 - bitIndex;
        if (array[index] == '0')
        {
            array[index] = '1';
        }
        else
        {
            array[index] = '0';
        }
        str = string.Join(string.Empty, array);
        return Convert.ToInt32(str, 2);
    }
}