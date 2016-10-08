using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new[] { 2, 4, 6 }, Kata.Maps(new[] { 1, 2, 3 }));
        Assert.AreEqual(new[] { 8, 2, 2, 2, 8 }, Kata.Maps(new[] { 4, 1, 1, 1, 4 }));
        Assert.AreEqual(new[] { 4, 4, 4, 4, 4, 4 }, Kata.Maps(new[] { 2, 2, 2, 2, 2, 2 }));
    }
}

