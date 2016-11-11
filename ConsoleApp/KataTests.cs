using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual(4, Kata.getVolumeOfCubiod(1, 2, 2));
        Assert.AreEqual(63, Kata.getVolumeOfCubiod(6.3, 2, 5));
    }
}

