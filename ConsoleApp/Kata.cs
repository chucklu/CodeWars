using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/how-many-times-does-it-contain/train/csharp
/// </summary>
public class Kata
{
    public static int stringCounter(string inputS, string charS)
    {
        return inputS.Count(x => x == charS[0]);
    }
}