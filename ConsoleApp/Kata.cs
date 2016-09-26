﻿/// <summary>
/// https://www.codewars.com/kata/swap-values/train/csharp
/// </summary>
public class Swapper
{
    public object[] Arguments { get; private set; }

    public Swapper(object[] args)
    {
        Arguments = args;
    }

    public void SwapValues()
    {
        object[] args = new[] { Arguments[0], Arguments[1] };

        object temp = args[0];
        Arguments[0] = args[1];
        Arguments[1] = temp;
    }
}