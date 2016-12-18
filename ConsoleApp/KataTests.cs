using NUnit.Framework;

[TestFixture]
public class KataTests
{
    public void IpValidatorTest(string ip, bool isValid)
    {
        int[] numbers = { 5, 8, 12, 19, 22 };
        Assert.AreEqual(13, Kata.sumTwoSmallestNumbers(numbers));
    }
}

