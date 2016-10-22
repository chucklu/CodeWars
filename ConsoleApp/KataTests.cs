using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new int[] { 1 }, Kata.distinct(new int[] { 1 }));
        Assert.AreEqual(new int[] { 1, 2 }, Kata.distinct(new int[] { 1, 2 }));
        Assert.AreEqual(new int[] { 1, 2 }, Kata.distinct(new int[] { 1, 1, 2 }));
    }
}

