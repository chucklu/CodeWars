using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(Kata.Disemvowel("This website is for losers LOL!"),"Ths wbst s fr lsrs LL!");
    }
}

