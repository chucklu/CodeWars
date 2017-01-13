using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        var r = new List<int[]>
        {
            new int[] {1, 1},
            new int[] {1, 2},
            new int[] {1, 3},
            new int[] {2, 1},
            new int[] {2, 3},
            new int[] {3, 1},
            new int[] {3, 2},
            new int[] {3, 3},
        };
        var list = Kata.cartesianNeighbor(2, 2).ToList();
        Console.WriteLine(list.Count);
        //Assert.AreEqual(r, Inspection.sortedList(list));
    }
}

