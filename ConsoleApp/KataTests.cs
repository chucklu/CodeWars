using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(1, Kata.getNumberFromString("1"));
        Assert.AreEqual(123, Kata.getNumberFromString("123"));
        Assert.AreEqual(7, Kata.getNumberFromString("this is number: 7"));
    }
}

