using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FabricLiving<T> : Fabric<T> where T : LivingEntity
{
    protected override void SpawnEntity()
    {
        base.SpawnEntity();

        LivingEntity livingEntity = _pool.DisavleObject[0];
        livingEntity.gameObject.SetActive(true);
        livingEntity.transform.position = GetPositionSpawn();

    }
}
