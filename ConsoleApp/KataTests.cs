using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("whatfickdamncake", Kata.Borrow("WhAt! FiCK! DaMn CAke?"));
        Assert.AreEqual("thebigpeoplehere", Kata.Borrow("THE big PeOpLE Here!!"));
        Assert.AreEqual("iamatinyboy", Kata.Borrow("i AM a TINY BoY!!"));
    }
}

