using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(1, Kata.factorial(0));
        Assert.AreEqual(1, Kata.factorial(1));
        Assert.AreEqual(2, Kata.factorial(2));
        Assert.AreEqual(6, Kata.factorial(3));
        Assert.AreEqual(24, Kata.factorial(4));
        Assert.AreEqual(120, Kata.factorial(5));
    }
}

