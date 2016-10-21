using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("One", Kata.SwitchItUp(1));
        Assert.AreEqual("Three", Kata.SwitchItUp(3));
        Assert.AreEqual("Five", Kata.SwitchItUp(5));
    }
}

