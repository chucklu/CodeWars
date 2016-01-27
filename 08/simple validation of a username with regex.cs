//http://www.codewars.com/kata/56a3f08aa9a6cc9b75000023/train/csharp
using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool ValidateUsr(string username)
    {
        string pattern = "^[a-z0-9_]{4,16}$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(username);
    }
}