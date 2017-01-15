using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(254, Kata.Mod256WithoutMod(254));
        Assert.AreEqual(0, Kata.Mod256WithoutMod(256));
        Assert.AreEqual(2, Kata.Mod256WithoutMod(258));

        Assert.AreEqual(-254, Kata.Mod256WithoutMod(-254));
        Assert.AreEqual(0, Kata.Mod256WithoutMod(-256));
        Assert.AreEqual(-2, Kata.Mod256WithoutMod(-258));
    }
}

