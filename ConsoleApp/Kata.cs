/// <summary>
/// https://www.codewars.com/kata/uefa-euro-2016/train/csharp
/// </summary>
public class Kata
{
    public static string UefaEuro2016(string[] teams, int[] scores)
    {
        string str;
        if (scores[0] > scores[1])
        {
            str = $"At match {teams[0]} - {teams[1]}, {teams[0]} won!";
        }
        else if (scores[0] == scores[1])
        {
            str = $"At match {teams[0]} - {teams[1]}, teams played draw.";
        }
        else
        {
            str = $"At match {teams[0]} - {teams[1]}, {teams[1]} won!";
        }
        return str;
    }
}