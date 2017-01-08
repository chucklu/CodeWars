/// <summary>
/// https://www.codewars.com/kata/how-many-e-mails-we-sent-today/train/csharp
/// </summary>
public class Kata
{
    public static string CountEmails(int sent, int limit = 1000)
    {
        if (sent == 0)
        {
            return "No e-mails sent";
        }
        if (sent > limit)
        {
            return "Daily limit is reached";
        }
        return $"{sent * 100 / limit}%";
    }
}