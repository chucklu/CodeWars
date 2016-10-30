using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void ExampleTests()
    {
        var scores = new int[] { 49, 3, 5, 300, 7 };
        Assert.AreEqual(73, Kata.Average(scores));

        scores = new int[] { 90, 98, 89, 100, 100, 86, 94 };
        Assert.AreEqual(94, Kata.Average(scores));
    }
}

