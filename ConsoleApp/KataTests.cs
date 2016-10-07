using NUnit.Framework;

namespace Solution
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(0, Program.binToDec("0"));
            Assert.AreEqual(1, Program.binToDec("1"));
            Assert.AreEqual(2, Program.binToDec("10"));
            Assert.AreEqual(3, Program.binToDec("11"));
            Assert.AreEqual(6, Program.binToDec("110"));
        }
    }
}
