using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void ExampleTests()
    {
        Assert.AreEqual(8, Kata.findSum(5));
        Assert.AreEqual(33, Kata.findSum(10));
    }
}

