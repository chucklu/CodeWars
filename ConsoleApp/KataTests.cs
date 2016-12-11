using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("ABC", Kata.alternateCase("abc"));
        Assert.AreEqual("abc", Kata.alternateCase("ABC"));
        Assert.AreEqual("hELLO wORLD", Kata.alternateCase("Hello World"));
    }
}

