/// <summary>
/// https://www.codewars.com/kata/grasshopper-personalized-message/train/csharp
/// </summary>
public class Kata
{
    public static string Greet(string name, string owner)
    {
        if (name.Equals(owner))
        {
            return "Hello boss";
        }
        return "Hello guest";
    }
}