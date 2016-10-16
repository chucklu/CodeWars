using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [TestCase("123", "Odd is greater than Even")]
    [TestCase("12", "Even is greater than Odd")]
    [TestCase("112", "Even and Odd are the same")]
    public void BasicTests(string input, string expectedResult)
    {
        Assert.AreEqual(expectedResult, EvenOrOddKata.EvenOrOdd(input));
    }
}

