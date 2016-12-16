using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

[TestFixture]
public class KataTests
{
    [TestCase(new[] { 2, 3, 4, 5, 6 }, true)]
    [TestCase(new[] { 14, 5, 4, 2, 3 }, true)]
    [TestCase(new[] { 7, 7, 12, 11, 3, 4, 14 }, false)]
    [TestCase(new[] { 7, 3, 2 }, false)]
    public void IsStraight(IEnumerable<int> cardValues, bool isStraight)
    {
        var cards = new List<Card>();
        if (cardValues == null)
        {
            throw  new ArgumentNullException(nameof(cardValues));
        }
        var list = cardValues.ToList();
        foreach (var cardValue in list)
        {
            cards.Add(new Card { CardValue = cardValue });
         }

        Assert.AreEqual(isStraight, PokerHand.IsStraight(cards), string.Join(", ", list.Select(v => v)));
    }
}

