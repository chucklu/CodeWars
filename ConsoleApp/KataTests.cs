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
        var a = new List<string>() {"bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"};
        testing(Kata.ContainAllRots("bsjq", a), true);
        a = new List<string>() {};
        testing(Kata.ContainAllRots("", a), true);
        a = new List<string>() {"bsjq", "qbsj"};
        testing(Kata.ContainAllRots("", a), true);
        a = new List<string>() {"TzYxlgfnhf", "yqVAuoLjMLy", "BhRXjYA", "YABhRXj", "hRXjYAB", "jYABhRX", "XjYABhR", "ABhRXjY"};
        testing(Kata.ContainAllRots("XjYABhR", a), false);
    }
}

