using System;

public static class StringExts
{
	public static TimeSpan ToTimeSpan(this string str, TimeSpan defaultValue)
	{
		bool isTimeSpan = TimeSpan.TryParse(str, out TimeSpan timeSpan);

		return isTimeSpan ? timeSpan : defaultValue;
	}
}
