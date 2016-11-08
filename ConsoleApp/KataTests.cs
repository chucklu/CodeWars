using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new[] { "+0", "+10", "+15", "-10" }, Kata.Equalize(new[] { 20, 30, 35, 10 }));
        Assert.AreEqual(new string[] { }, Kata.Equalize(new int[] { }));
        Assert.AreEqual(new[] { "+0", "+2", "+14", "+40", "-10", "+5", "+10" }, Kata.Equalize(new[] { 10, 12, 24, 50, 0, 15, 20 }));
    }
}

