using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(new string[] { "Robin", "Singh" }, Kata.StringToArray("Robin Singh"));
    }
}

