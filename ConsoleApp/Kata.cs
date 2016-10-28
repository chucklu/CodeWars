/// <summary>
/// https://www.codewars.com/kata/dont-give-me-five/train/csharp
/// </summary>
public class Kata
{
    public static int DontGiveMeFive(int start, int end)
    {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            var s = i.ToString();
            if (s.Contains("5") == false)
            {
                count++;
            }
        }
        return count;
    }
}