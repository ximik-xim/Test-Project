using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public static class MyScripts 
{
    public static bool Range(float value, float target,float range)
    {
        if (value >= target - range && value <= target + range)  
        {
            return true;
        }

        return false;
    }

    public static bool Range(Vector4 value, Vector4 target, float range)
    {
        return RangeArray(value, target, range, 4);
    }

    public static bool Range(Vector4 value, Vector4 target, Vector4 range)
    {
        return RangeArray(value, target, range, 4);
    }
    
    public static bool Range(Vector3 value, Vector3 target, float range)
    {
        return RangeArray(value, target, range, 3);
    }

    public static bool Range(Vector3 value, Vector3 target, Vector3 range)
    {
        return RangeArray(value, target, range, 3);
    }

    public static bool Range(Vector2 value, Vector2 target, float range)
    {
        return RangeArray(value, target, range, 2);
    }

    public static bool Range(Vector2 value, Vector2 target, Vector2 range)
    {
        return RangeArray(value, target, range, 2);
    }

    private static bool RangeArray(Vector4 value, Vector4 target,float range, int arraySize)
    {
        float valueElement;
        float targetElement;
        
        for (int i = 0; i < arraySize; i++)
        {
            valueElement = value[i];
            targetElement = target[i];
        
            if (valueElement >= targetElement - range && valueElement <= targetElement + range)
            {
                continue;
            }
        
            return false;
        }
        
        return true;
    }
    
    private static bool RangeArray(Vector4 value, Vector4 target,Vector4 range, int arraySize)
    {
        float valueElement;
        float targetElement;
        float rangeElement;
        
        for (int i = 0; i < arraySize; i++)
        {
            valueElement = value[i];
            targetElement = target[i];
            rangeElement = range[i];

            if (valueElement >= targetElement - rangeElement && valueElement <= targetElement + rangeElement)
            {
                continue;
            }

            return false;
        }
        
        return true;
    }
}
