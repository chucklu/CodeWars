using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("Jack Ryan", Kata.InitializeNames("Jack Ryan"));
        Assert.AreEqual("Lois M. Lane", Kata.InitializeNames("Lois Mary Lane"));
        Assert.AreEqual("Dimitri", Kata.InitializeNames("Dimitri"));
        Assert.AreEqual("Alice B. C. Davis", Kata.InitializeNames("Alice Betty Catherine Davis"));
    }
}

