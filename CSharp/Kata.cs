using System.Collections.Generic;

/// <summary>
/// https://www.codewars.com/kata/cartesian-neighbors/train/csharp
/// </summary>
public class Kata
{
    public static IEnumerable<int[]> cartesianNeighbor(int x, int y)
    {
        var list = new List<int[]>();
        for (int i = x - 1; i <= x + 1; i++)
        {
            for (int j = y - 1; j <= y + 1; j++)
            {
                if (i == x && j == y)
                {
                }
                else
                {
                    list.Add(new[] { i, j });
                }
            }
        }
        return list;
    }
}
