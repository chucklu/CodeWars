using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new int[] { -1, 0, 2, 3 }, Kata.FindMissingNumbers(new int[] { -3, -2, 1, 4 }));
        Assert.AreEqual(new int[0], Kata.FindMissingNumbers(new int[] { -1, 0, 1, 2, 3, 4 }));
        Assert.AreEqual(new int[0], Kata.FindMissingNumbers(new int[0]));
    }
}

