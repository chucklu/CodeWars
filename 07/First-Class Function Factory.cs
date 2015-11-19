//http://www.codewars.com/kata/first-class-function-factory
using System;
using System.Linq;

public class FunctionFactory
{
    private static int multiple;

    public static Func<int[], int[]> factory(int x)
    {
        multiple = x;
        return Task;
    }

    public static int[] Task(int[] array)
    {
        return array.Select(x => x*multiple).ToArray();
    }
}