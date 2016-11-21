/// <summary>
/// https://www.codewars.com/kata/recursion-number-1-factorial/train/csharp
/// </summary>
public class Recursion
{
    public static ulong Factorial(ulong n)
    {
        checked
        {
            if (n == 0||n==1)
            {
                return 1;
            }
            return n*Factorial(n - 1);
        }
    }
}