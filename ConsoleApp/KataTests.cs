using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        string[] expected = { "Ryan", "Mark" };
        string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
        CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
    }
}

