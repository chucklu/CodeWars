using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(1, Kata.UnluckyDays(1586));
        Assert.AreEqual(3, Kata.UnluckyDays(1001));
        Assert.AreEqual(2, Kata.UnluckyDays(2819));
        Assert.AreEqual(2, Kata.UnluckyDays(2792));
        Assert.AreEqual(2, Kata.UnluckyDays(2723));
        Assert.AreEqual(1, Kata.UnluckyDays(1909));
        Assert.AreEqual(2, Kata.UnluckyDays(1812));
        Assert.AreEqual(2, Kata.UnluckyDays(1618));
        Assert.AreEqual(1, Kata.UnluckyDays(2132));
        Assert.AreEqual(3, Kata.UnluckyDays(2065));
    }
}

