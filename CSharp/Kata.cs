/// <summary>
/// https://www.codewars.com/kata/adding-values-of-arrays-in-a-shifted-way/train/csharp
/// </summary>
public static class Kata
{
    public static int[] AddingShifted(int[][] arrayOfArrays, int shift)
    {
        var row = arrayOfArrays.GetLength(0);
        var originColumn = arrayOfArrays[0].Length;
        int column = shift*(row - 1) + originColumn;
        var tempArrayOfArrays = new int[row][];
        for (int i = 0; i < row; i++)
        {
            var begin = shift*i;
            tempArrayOfArrays[i] = GetArray(begin, column, arrayOfArrays[i]);
        }

        var temp = new int[column];
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < row; j++)
            {
                temp[i] = temp[i] + tempArrayOfArrays[j][i];
            }
        }
        return temp;
    }

    private static int[] GetArray(int begin,int total,int[] tempArray)
    {
        var array = new int[total];
        for (int i = 0; i < total; i++)
        {
            if (i < begin)
            {
                continue;
            }
            if (i - begin < tempArray.Length)
            {

                array[i] = tempArray[i - begin];
            }
            else
            {
                break;
            }
        }
        return array;
    }
}

