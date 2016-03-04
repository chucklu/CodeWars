using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// http://www.codewars.com/kata/add-more-item-to-list-bug-fixes/csharp
/// </summary>
public class AddMore
{
    public static List<int> AddExtra(List<int> listOfNumbers)
    {
        var list = listOfNumbers.ToList();
        list.Add(3);
        return list;
    }
}