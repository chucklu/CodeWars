using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new int[] { 1 }, Kata.PreFizz(1), "Array should be from 1 to 1");
        Assert.AreEqual(new int[] { 1, 2 }, Kata.PreFizz(2), "Array should be from 1 to 2");
        Assert.AreEqual(new int[] { 1, 2, 3 }, Kata.PreFizz(3), "Array should be from 1 to 3");
        Assert.AreEqual(new int[] { 1, 2, 3, 4 }, Kata.PreFizz(4), "Array should be from 1 to 4");
        Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, Kata.PreFizz(5), "Array should be from 1 to 5");
    }
}

