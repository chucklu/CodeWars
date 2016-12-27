using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(true, Kata.OnlyOne());
        Assert.AreEqual(true, Kata.OnlyOne(true, false));
    }
}

