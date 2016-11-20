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
            //a+b?
            Assert.AreEqual(1, new Kata().Testit(0, 1));
            Assert.AreEqual(3, new Kata().Testit(1, 2));
            Assert.AreEqual(30, new Kata().Testit(10, 20));
            //a*b?
            Assert.AreEqual(1, new Kata().Testit(1, 1));
            Assert.AreEqual(3, new Kata().Testit(1, 3));

            Assert.AreEqual(2, new Kata().Testit(2, 2));
            Assert.AreEqual(31, new Kata().Testit(11, 22));
        }
    }
}

