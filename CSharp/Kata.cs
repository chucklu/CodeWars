/// <summary>
/// https://www.codewars.com/kata/fac-recursion-pest-control-find-the-bugs-and-fix-them/train/csharp
/// </summary>
public class Kata
{
    public int FacCalculation(int startValue)
    {
        return FacRecursion(startValue);
    }

    protected int FacRecursion(int value)
    {
        if (value < 0)
        {
            return 0;
        }
        if (value == 1 || value == 0)
        {
            return 1;
        }
        return value*FacRecursion(value - 1);
    }
}