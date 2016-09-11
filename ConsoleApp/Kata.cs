using System.Linq;

/// <summary>
/// http://www.codewars.com/kata/is-there-a-vowel-in-there/train/csharp
/// </summary>
public class Kata
{
    public static int[] vowels = { 'a', 'e', 'i', 'o', 'u' };

    public static object[] IsVow(object[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            int value = (int)a[i];
            if (vowels.Contains(value))
            {
                a[i] = ((char)value).ToString();
            }
        }
        return a;
    }
}