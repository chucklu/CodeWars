using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class KataTests
{
    private static void testing(bool actual, bool expected)
    {
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(true, Kata.Compare("AD", "BC"));
        Assert.AreEqual(false, Kata.Compare("AD", "DD"));
    }
}

