using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("1", Kata.Pattern(1));
        Assert.AreEqual("12\n2", Kata.Pattern(2));
        Assert.AreEqual("12345\n2345\n345\n45\n5", Kata.Pattern(5));
    }
}

