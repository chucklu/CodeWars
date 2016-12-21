using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(5.75, Kata.CalculateTotal(5.00, 5, 10));
        Assert.AreEqual(45.10, Kata.CalculateTotal(36.97, 7, 15));
    }
}

