using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/friend-or-foe/train/csharp
/// </summary>
public static class Kata
{
    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        return names.Where(x => x.Length == 4);
    }
}