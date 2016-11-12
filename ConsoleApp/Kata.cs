/// <summary>
/// https://www.codewars.com/kata/return-the-closest-number-multiple-of-10/train/csharp
/// </summary>
public class Kata
{
    public int ClosestMultiple10(int num)
    {
        int n = num % 10;
        if (n <= 4)
        {
            num = num - n;
        }
        else
        {
            num = (num / 10 + 1) * 10;
        }
        return num;
    }
}