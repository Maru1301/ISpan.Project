using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public static class StringExts
{
	public static TimeSpan ToTimeSpan(this string str, TimeSpan defaultValue)
	{
		bool isTimeSpan = TimeSpan.TryParse(str, out TimeSpan timeSpan);

		return isTimeSpan ? timeSpan : defaultValue;
	}

	public static int ToInt(this string str, int defaultValue)
	{
		bool isInt = int.TryParse(str, out int value);

		return isInt ? value : defaultValue;
	}
}
