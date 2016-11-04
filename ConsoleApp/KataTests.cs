using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void ExampleTests()
    {
        int[] test1 = { 0, 1 },
          test2 = { 1, 4, 6 },
          test3 = { 3, 4, 5 },
          test4 = { 2, 1 },
          test5 = { 1, 4, 4, 6 },
          sol1 = { 0, 1 },
          sol2 = { 0, 1, 2, 3, 4, 5, 6 },
          sol3 = { 0, 1, 2, 3, 4, 5 },
          sol4 = { 0, 1, 2 },
          sol5 = { 0 };
        Assert.AreEqual(sol1, Kata.CompleteSeries(test1));
        Assert.AreEqual(sol2, Kata.CompleteSeries(test2));
        Assert.AreEqual(sol3, Kata.CompleteSeries(test3));
        Assert.AreEqual(sol4, Kata.CompleteSeries(test4));
        Assert.AreEqual(sol5, Kata.CompleteSeries(test5));
    }
}

