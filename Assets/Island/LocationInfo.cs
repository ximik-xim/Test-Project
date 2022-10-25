using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class LocationInfo : MonoBehaviour, ITypeTrigger
{
    public event Action LostEntity;
    public bool EntityLost { get; private set; }

    public void ChectEntity(int countLiveEntity,int countDeadEntity)
    {
        if (countLiveEntity == 0)
        {
            EntityLost = true;
            LostEntity?.Invoke();
        }
    }

    public TypeTrigger GetTypeTrigger()
    {
        return TypeTrigger.LocalInfo;
    }
}
