/// <summary>
/// https://www.codewars.com/kata/keep-up-the-hoop/train/csharp
/// </summary>
public class Kata
{
    private const string A = "Great, now move on to tricks";

    private const string B = "Keep at it until you get it";

    public static string HoopCount(int n)
    {
        if (n >= 10)
        {
            return A;
        }
        return B;
    }
}