using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(2, Kata.Stray(new int[] { 1, 1, 2 }));
    }
}

