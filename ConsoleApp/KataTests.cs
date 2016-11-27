using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(56, Kata.SumTriangularNumbers(6));
        Assert.AreEqual(7140, Kata.SumTriangularNumbers(34));
        Assert.AreEqual(0, Kata.SumTriangularNumbers(-291));
        Assert.AreEqual(140205240, Kata.SumTriangularNumbers(943));
        Assert.AreEqual(0, Kata.SumTriangularNumbers(-971));
    }
}

