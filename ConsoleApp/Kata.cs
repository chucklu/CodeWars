/// <summary>
/// https://www.codewars.com/kata/factorial-1/train/csharp
/// </summary>
public class Kata
{
    public static int factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n*factorial(n - 1);
    }
}