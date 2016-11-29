using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("Vader soid: No, I am your fother!", Kata.ReplaceNth("Vader said: No, I am your father!", 2, 'a', 'o'));
        Assert.AreEqual("Vader said: No, I am your fother!", Kata.ReplaceNth("Vader said: No, I am your father!", 4, 'a', 'o'));
        Assert.AreEqual("Vader said: No, I am your father!", Kata.ReplaceNth("Vader said: No, I am your father!", 6, 'a', 'o'));
        Assert.AreEqual("Vader said: No, I am your father!", Kata.ReplaceNth("Vader said: No, I am your father!", 0, 'a', 'o'));
        Assert.AreEqual("Vader said: No, I am your father!", Kata.ReplaceNth("Vader said: No, I am your father!", -2, 'a', 'o'));
        Assert.AreEqual("Vader sayd: No, I am your father!", Kata.ReplaceNth("Vader said: No, I am your father!", 1, 'i', 'y'));

        Assert.AreEqual("Luke cries: Noooooioooooioooo!", Kata.ReplaceNth("Luke cries: Noooooooooooooooo!", 6, 'o', 'i'));
    }
}

