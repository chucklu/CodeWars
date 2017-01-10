using System;
using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        var result = Kata.SquareAreaToCircle(20);
        Assert.AreEqual(Math.Round(result, 8), Math.Round(15.707963267948969d, 8));

        result = Kata.SquareAreaToCircle(9);
        Assert.AreEqual(result.GetType(), typeof(double), "should a be double");
        Assert.AreEqual(Math.Round(result, 8), Math.Round(7.0685834705770345d, 8));
    }
}

