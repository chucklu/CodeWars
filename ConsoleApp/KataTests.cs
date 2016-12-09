using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(100.00M, Kata.DiscoverOriginalPrice(75M, 25M));
    }
}

