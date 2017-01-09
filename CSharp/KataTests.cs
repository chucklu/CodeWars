using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(7, Kata.FlipBit(15, 4));
        Assert.AreEqual(1, Kata.FlipBit(0, 1));
        Assert.AreEqual(14, Kata.FlipBit(15, 1));
    }
}

