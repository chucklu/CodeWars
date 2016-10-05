using NUnit.Framework;

namespace Solution
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("***", Program.repeatStr(3, "*"));
        }
    }
}
