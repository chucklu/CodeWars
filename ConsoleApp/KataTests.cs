using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, Recursion.Factorial(0));
            Assert.AreEqual(1, Recursion.Factorial(1));
            Assert.AreEqual(2, Recursion.Factorial(2));
            Assert.AreEqual(6, Recursion.Factorial(3));
        }
    }
}

