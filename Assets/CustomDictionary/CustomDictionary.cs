using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
public class CustomDictionary<K,D>:Dictionary<K,D>
{
    [SerializeField]
    private List<KeyAndData<K, D>> _listKeyAndData;

    public void Initialization()
    {
        for (int i = 0; i < _listKeyAndData.Count; i++)
        {
            this.Add(_listKeyAndData[i]._key,_listKeyAndData[i]._data);    
        }
        //пока просто очищаю, но потом можно будет прямое взаимодействие захерачить, ноооо как то ща в падлу
        _listKeyAndData.Clear();
    }
    
}

[System.Serializable]
public class KeyAndData<K, D>
{
    public K _key;
    public D _data;
}