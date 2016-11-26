using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    [TestCase(5, ExpectedResult = 10)]
    [TestCase(0, ExpectedResult = 5)]
    [TestCase(-5, ExpectedResult = 0)]
    public static int FixedTest(int num)
    {
        return Kata.AddFive(num);
    }
}

