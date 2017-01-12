using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("TTTT", DnaStrand.MakeComplement("AAAA"));
        Assert.AreEqual("TAACG", DnaStrand.MakeComplement("ATTGC"));
        Assert.AreEqual("CATA", DnaStrand.MakeComplement("GTAT"));
    }
}

