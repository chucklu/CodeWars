using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(2, Kata.stringCounter("Hello world", "o"));
        Assert.AreEqual(4, Kata.stringCounter("Wait isn't it supposed to be cynical?", "i"));
        Assert.AreEqual(4, Kata.stringCounter("I'm gona be the best code warrior ever dad", "r"));
        Assert.AreEqual(1, Kata.stringCounter("Do you like Harry Potter?", "?"));
    }
}

