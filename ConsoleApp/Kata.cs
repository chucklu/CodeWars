using System.Threading;

/// <summary>
/// https://www.codewars.com/kata/jaden-casing-strings/train/csharp
/// </summary>
public static class Kata
{
    public static string ToJadenCase(this string phrase)
    {
        return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(phrase);
    }
}