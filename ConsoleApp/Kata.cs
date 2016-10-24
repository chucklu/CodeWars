/// <summary>
/// https://www.codewars.com/kata/basic-mathematical-operations/train/csharp
/// </summary>
public static class Kata
{
    public static double basicOp(char op, double val1, double val2)
    {
        double result = 0;
        switch (op)
        {
            case '+':
                result = val1 + val2;
                break;
            case '-':
                result = val1 - val2;
                break;
            case '*':
                result = val1 * val2;
                break;
            case '/':
                result = val1 / val2;
                break;
        }
        return result;
    }
}
