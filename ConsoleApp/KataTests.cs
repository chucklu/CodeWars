using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(6, Kata.Grow(new[] { 1, 2, 3 }));
        Assert.AreEqual(16, Kata.Grow(new[] { 4, 1, 1, 1, 4 }));
        Assert.AreEqual(64, Kata.Grow(new[] { 2, 2, 2, 2, 2, 2 }));
    }
}

