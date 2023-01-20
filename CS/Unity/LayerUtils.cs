using System;
using System.Collections.Generic;
using UnityEngine;

public class LayerUtils : MonoBehaviour
{
    public static GameObject[] FindGameObjectsInLayer(LayerMask layerMask, bool includeInactive = false)
    {
        GameObject[] goArray = FindObjectsOfType(typeof(GameObject), includeInactive) as GameObject[];
        List<GameObject> goList = new List<GameObject>();

        for (int i = 0; i < goArray.Length; i++)
        {
            if (CompareLayers(goArray[i].gameObject.layer, layerMask))
            {
                goList.Add(goArray[i]);
            }
        }

        return goList.ToArray();
    }

    public static T[] FindComponentsInLayer<T>(LayerMask layerMask, bool includeInactive = false) where T : Component
    {
        T[] goArray = FindObjectsOfType(typeof(T), includeInactive) as T[];
        List<T> goList = new List<T>();

        for (int i = 0; i < goArray.Length; i++)
        {
            if (CompareLayers(goArray[i].gameObject.layer, layerMask))
            {
                goList.Add(goArray[i]);
            }
        }

        return goList.ToArray();
    }

    public static bool CompareLayers(int gameObjectLayer, LayerMask layerMask)
    {
        return (layerMask & 1 << gameObjectLayer) == 1 << gameObjectLayer;
    }
}
