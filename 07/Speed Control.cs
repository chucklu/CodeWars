//http://www.codewars.com/kata/speed-control
using System;
using System.Linq;

public class GpsSpeed
{
    public static int Gps(int s, double[] x)
    {
        return x.Length < 2 ? 0 : Convert.ToInt32(Math.Floor(Enumerable.Range(0, x.Length - 1).Select(n => (x[n + 1] - x[n])/s*3600).Max()));
    }
}