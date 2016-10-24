using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(Kata.basicOp('+', 4, 7), 11);
        Assert.AreEqual(Kata.basicOp('-', 15, 18), -3);
        Assert.AreEqual(Kata.basicOp('*', 5, 5), 25);
        Assert.AreEqual(Kata.basicOp('/', 49, 7), 7);
    }
}

