using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(string.Join(",", new int[] { 1 }), string.Join(",", Kata.Climb(1)));
        Assert.AreEqual(string.Join(",", new int[] { 1, 2, 5, 10 }), string.Join(",", Kata.Climb(10)));
        Assert.AreEqual(string.Join(",", new int[] { 1, 3, 6, 13 }), string.Join(",", Kata.Climb(13)));
    }
}

