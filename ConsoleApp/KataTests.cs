using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("yes, ascending", Kata.IsSortedAndHow(new[] { 1, 2 }));
        Assert.AreEqual("yes, descending", Kata.IsSortedAndHow(new[] { 15, 7, 3, -8 }));
        Assert.AreEqual("no", Kata.IsSortedAndHow(new[] { 4, 2, 30 }));
    }
}

