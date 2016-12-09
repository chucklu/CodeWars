using System;

/// <summary>
/// https://www.codewars.com/kata/discover-the-original-price/train/csharp
/// </summary>
public class Kata
{
    public static decimal DiscoverOriginalPrice(decimal discountedPrice, decimal salePercentage)
    {
        decimal origin = discountedPrice / (1 - salePercentage / 100);
        decimal o = Math.Round(origin, 2);
        return o;
    }
}