using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void ExampleTests()
    {
        Assert.AreEqual(8, Kata.DontGiveMeFive(1, 9));
        Assert.AreEqual(12, Kata.DontGiveMeFive(4, 17));
    }
}

