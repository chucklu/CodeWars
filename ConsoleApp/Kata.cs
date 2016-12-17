using System.Linq;
using System.Net;

/// <summary>
/// https://www.codewars.com/kata/ipv4-validator/train/csharp
/// </summary>
public class Kata
{
    public static bool IpValidator(string ip)
    {
        if (ip.Count(c => c == '.') != 3) return false;
        IPAddress address;
        return IPAddress.TryParse(ip, out address);
    }
}