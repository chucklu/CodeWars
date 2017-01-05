/// <summary>
/// https://www.codewars.com/kata/simple-fun-number-1-seats-in-theater/train/csharp
/// </summary>
public class Kata
{
    public static int SeatsInTheater(int nCols, int nRows, int col, int row)
    {
        return (nCols - col + 1) * (nRows - row);
    }
}