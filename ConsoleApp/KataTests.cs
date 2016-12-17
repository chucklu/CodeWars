using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [TestCase("123.456.789.0", false)]
    [TestCase("127.0.0.1", true)]
    public void IpValidatorTest(string ip, bool isValid)
    {
        Assert.AreEqual(isValid, Kata.IpValidator(ip));
    }
}

