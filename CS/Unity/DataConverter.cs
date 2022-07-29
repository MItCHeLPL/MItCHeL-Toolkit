using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class DataConverter
{
	//LIST AND ARRAYS
	public static T[] ListToArray<T>(List<T> list)
	{
		T[] array = new T[list.Count];

		for (int i = 0; i < list.Count; i++)
		{
			array[i] = list[i];
		}

		return array;
	}
	public static List<T> ArrayToList<T>(T[] array)
	{
		List<T> list = new List<T>();

		for (int i = 0; i < array.Length; i++)
		{
			list.Add(array[i]);
		}

		return list;
	}


	//DICTIONARIES
	public static Dictionary<T1, T2> ArraysToDictionary<T1, T2>(T1[] keys, T2[] values)
    {
		Dictionary<T1, T2> output = new Dictionary<T1, T2>();

		for(int i=0; i< keys.Length; i++)
        {
			output.Add(keys[i], values[i]);
		}

		return output;
	}


	//MATH
	public static float Map(float value, float oldMinValue, float oldMaxValue, float newMinValue, float newMaxValue)
	{
		return newMinValue + (value - oldMinValue) * (newMaxValue - newMinValue) / (oldMaxValue - oldMinValue); //Map value from old range onto a new range
	}
	public static int Map(int value, int oldMinValue, int oldMaxValue, int newMinValue, int newMaxValue)
	{
		return newMinValue + (value - oldMinValue) * (newMaxValue - newMinValue) / (oldMaxValue - oldMinValue); //Map value from old range onto a new range
	}

	public static float MapFrom01(float value, float newMinValue, float newMaxValue)
	{
		return newMinValue + (value - 0) * (newMaxValue - newMinValue) / (1 - 0); //Map value from old range onto a new range
	}
	public static float MapTo01(float value, float oldMinValue, float oldMaxValue)
	{
		return 0 + (value - oldMinValue) * (1 - 0) / (oldMaxValue - oldMinValue); //Map value from old range onto a new range
	}
}
