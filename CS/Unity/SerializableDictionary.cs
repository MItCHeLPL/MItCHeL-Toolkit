using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SerializableDictionary<TKey, TValue> : ISerializationCallbackReceiver
{
    [System.Serializable]
    private struct Element
    {
        public TKey key;
        public TValue value;
    }

    [SerializeField] private List<Element> dictionaryAsList = new List<Element>();
    public Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

    public void OnAfterDeserialize()
    {
        dictionary.Clear();
        foreach (Element element in dictionaryAsList)
        {
            try
            {
                dictionary.Add(element.key, element.value);
            }
            catch (System.ArgumentException) { }
            finally { } //ignore doubled elements
        }
    }

    public void OnBeforeSerialize()
    {

        int countBefore = dictionaryAsList.Count;

        Element? last = countBefore != 0 ? (Element?)dictionaryAsList[countBefore - 1] : null;

        dictionaryAsList.Clear();
        foreach (KeyValuePair<TKey, TValue> pair in dictionary)
        {
            dictionaryAsList.Add(new Element
            {
                key = pair.Key,
                value = pair.Value
            });
        }

        if (countBefore > dictionaryAsList.Count)
        {
            dictionaryAsList.Add(last.Value);
        }
    }
}