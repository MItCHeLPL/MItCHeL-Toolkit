using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathUtils
{
    public static float Remap(float value, float oldMinValue, float oldMaxValue, float newMinValue, float newMaxValue, bool clamp = false)
    {
        if (clamp)
        {
            value = Mathf.Clamp(value, oldMinValue, oldMaxValue);
        }

        return newMinValue + (value - oldMinValue) * (newMaxValue - newMinValue) / (oldMaxValue - oldMinValue); //Map value from old range onto a new range
    }
    public static int Remap(int value, int oldMinValue, int oldMaxValue, int newMinValue, int newMaxValue, bool clamp = false)
    {
        if (clamp)
        {
            value = Mathf.Clamp(value, oldMinValue, oldMaxValue);
        }
        return newMinValue + (value - oldMinValue) * (newMaxValue - newMinValue) / (oldMaxValue - oldMinValue); //Map value from old range onto a new range
    }

    public static float RemapFrom01(float value, float newMinValue, float newMaxValue, bool clamp = false)
    {
        if (clamp)
        {
            value = Mathf.Clamp01(value);
        }

        return newMinValue + (value - 0) * (newMaxValue - newMinValue) / (1 - 0); //Map value from old range onto a new range
    }
    public static float RemapTo01(float value, float oldMinValue, float oldMaxValue, bool clamp = false)
    {
        if (clamp)
        {
            value = Mathf.Clamp(value, oldMinValue, oldMaxValue);
        }

        return 0 + (value - oldMinValue) * (1 - 0) / (oldMaxValue - oldMinValue); //Map value from old range onto a new range
    }
}
