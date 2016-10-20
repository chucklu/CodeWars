using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("Position of alphabet: 1", Kata.Position('a'));
        Assert.AreEqual("Position of alphabet: 26", Kata.Position('z'));
        Assert.AreEqual("Position of alphabet: 5", Kata.Position('e'));
    }
}

