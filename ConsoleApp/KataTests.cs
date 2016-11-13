using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new int[0], Kata.reverseList(new int[0]));
        Assert.AreEqual(new int[] { 3, 2, 1 }, Kata.reverseList(new int[] { 1, 2, 3 }));
    }
}

