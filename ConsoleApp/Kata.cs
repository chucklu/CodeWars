/// <summary>
/// https://www.codewars.com/kata/determine-offspring-sex-based-on-genes-xx-and-xy-chromosomes/train/csharp
/// </summary>
public class Kata
{
    public static string ChromosomeCheck(string sperm)
    {
        if (sperm.Contains("Y"))
        {
            return "Congratulations! You're going to have a son.";
        }
        else
        {
            return "Congratulations! You're going to have a daughter.";
        }
    }
}