using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/fake-binary/train/csharp
/// </summary>
public class Kata
{
    public static string FakeBin(string x)
    {
        return string.Join(string.Empty, x.Select(Fun));
    }

    public static char Fun(char c)
    {
        if (c < '5')
        {
            return '0';
        }
        return '1';
    }
}