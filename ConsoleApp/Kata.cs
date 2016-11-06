using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/help-bob-count-letters-and-digits/train/csharp
/// </summary>
public static class Kata
{
    public static int CountLettersAndDigits(string input)
    {
        return input.Count(char.IsLetterOrDigit);
    }
}