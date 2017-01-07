using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Kata fac = new Kata();

        Assert.AreEqual(1, fac.FacCalculation(1));

        Assert.AreEqual(6, fac.FacCalculation(3));
    }
}

