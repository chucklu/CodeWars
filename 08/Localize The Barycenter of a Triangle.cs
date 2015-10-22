//http://www.codewars.com/kata/localize-the-barycenter-of-a-triangle
using System;

public class Barycenter
{
	public static double[] BarTriang(double[] x, double[] y, double[] z)
	{
        double a = Math.Round((x[0] + y[0] + z[0])/3, 4);
        double b = Math.Round((x[1] + y[1] + z[1])/3, 4);
        double[] array = {a, b};
        return array;
    }
}