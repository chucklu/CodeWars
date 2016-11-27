/// <summary>
/// https://www.codewars.com/kata/sum-of-triangular-numbers/train/csharp
/// </summary>
public static class Kata
{
    public static int SumTriangularNumbers(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + (1 + i) * i / 2;
        }
        return sum;
    }
}