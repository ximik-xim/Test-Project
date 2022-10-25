using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public event Action<bool,MonoBehaviour> _enable;
    
    protected virtual void OnEnable()
    {
        _enable?.Invoke(true,this);
    }

    protected virtual void OnDisable()
    {
        _enable?.Invoke(false,this);
    }
}
