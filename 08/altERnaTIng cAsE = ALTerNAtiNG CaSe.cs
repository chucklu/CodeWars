using System;

namespace Extensions
{
	/// <summary>
	/// http://www.codewars.com/kata/56efc695740d30f963000557/train/csharp
	/// </summary>
	public static class StringExt
	{
		public static string ToAlternatingCase(this string s)
		{
			string tempString = string.Empty;
			foreach(char c in s)
			{
				char tempChar;
				if(char.IsLower(c))
				{
					tempChar = char.ToUpper(c);
				}
				else if(char.IsUpper(c))
				{
					tempChar = char.ToLower(c);
				}
				else
				{
					tempChar = c;
				}
				tempString = tempString + tempChar;
			}
			return tempString;
		}
	}
}