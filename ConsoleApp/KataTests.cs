﻿using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(7, Kata.CountLettersAndDigits("n!!ice!!123"));
    }
}

