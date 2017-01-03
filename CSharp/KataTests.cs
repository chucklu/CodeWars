using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("Keep at it until you get it", Kata.HoopCount(6), "Should work for 6");
        Assert.AreEqual("Great, now move on to tricks", Kata.HoopCount(22), "Should work for 22");
    }
}

