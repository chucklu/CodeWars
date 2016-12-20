using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("0+1+2+3+4+5+6 = 21", Kata.ShowSequence(6));
    }
}

