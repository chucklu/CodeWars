/// <summary>
/// https://www.codewars.com/kata/find-the-position/train/csharp
/// </summary>
public class Kata
{
    public static string Position(char alphabet)
    {
        int number = alphabet - 'a' + 1;
        return $@"Position of alphabet: {number}";
    }
}