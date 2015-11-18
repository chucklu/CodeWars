//http://www.codewars.com/kata/showing-x-to-y-of-z-products
using System;

public class Kata
{
    public static string PaginationText(int pageNumber, int pageSize, int totalProducts)
    {
        int temp = pageNumber*pageSize;
        int end = temp > totalProducts ? totalProducts : temp;
        int start = pageSize*(pageNumber - 1) + 1;
        string result = $"Showing {start} to {end} of {totalProducts} Products.";
        return result;
    }
}