using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FabricEnemi : FabricLiving<Enemi>
{
    private int i = -1;
    private void Start()
    {
        for (int i = 0; i < _pointSpawn.GetCoutnPoint(); i++)
        {
            Create();
        }
    }

    protected override Vector3 GetPositionSpawn()
    {
        i++;
        return _pointSpawn.GetPositionPoint(i);
    }
}
