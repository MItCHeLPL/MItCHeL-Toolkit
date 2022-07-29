using System;

public static class TimeConverter
{
	//output: xx:xx:xxxxx (mm:ss:ms)
	public static string ConvertTime(double time)
	{
		string output = TimeSpan.FromSeconds(time).ToString(@"mm\:ss\:fffff");
		return output;
	}
	public static string ConvertTime(float time)
	{
		return ConvertTime((double)time);
	}

	//output: xx:xx:xxx (mm:ss:ms)
	public static string ConvertTimeStripped(double time)
	{
		string output = TimeSpan.FromSeconds(time).ToString(@"mm\:ss\:fff");
		return output;
	}
	public static string ConvertTimeStripped(float time)
	{
		return ConvertTimeStripped((double)time);
	}

	//output: xx:xx (mm:ss)
	public static string ConvertTimeStrippedToSeconds(double time)
	{
		string output = TimeSpan.FromSeconds(time).ToString(@"mm\:ss");
		return output;
	}
	public static string ConvertTimeStrippedToSeconds(float time)
	{
		return ConvertTimeStrippedToSeconds((double)time);
	}
}
