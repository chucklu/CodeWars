/// <summary>
/// https://www.codewars.com/kata/mod-256-without-the-mod-operator/train/csharp
/// </summary>
public class Kata
{
    private static int mod = 256;

    public static int Mod256WithoutMod(int number)
    {
        if (number > 0)
        {
            while (number >= mod)
            {
                number = number - mod;
            }
        }
        else
        {
            while (number <= -mod)
            {
                number = number + mod;
            }
        }
        return number;
    }
}
