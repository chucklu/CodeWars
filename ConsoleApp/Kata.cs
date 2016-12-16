using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.codewars.com/kata/pokerhand-straight-or-not/train/csharp
/// </summary>
public static class PokerHand
{
    public static bool IsStraight(List<Card> cards)
    {
        bool flag = false;
        if (cards.Count < 5)
        {
            return flag;
        }
        var array = cards.Select(Ace).OrderBy(x => x).ToArray();
        flag = Is5Order(array);
        if (flag == false)
        {
            array = cards.Select(x => x.CardValue).OrderBy(x => x).ToArray();
            flag = Is5Order(array);
        }
        return flag;
    }

    private static bool Is5Order(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int count = 0;
            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[j] + 1 == array[j + 1])
                {
                    count++;
                    if (count == 4)
                    {
                        return true;
                    }
                }
                else if (array[j] == array[j + 1])
                {
                }
                else
                {

                    if (count < 4)
                    {
                        break;
                    }
                }
            }
        }
        return false;
    }

    private static int Ace(Card card)
    {
        if (card.CardValue == 14)
        {
            return 1;
        }
        return card.CardValue;
    }
}

public class Card
{
    public int CardValue { get; set; } // 2-14
}