using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public abstract class Fabric<T> : MonoBehaviour where T : Entity
{
    public  UnityEvent<int,int> UpdatedEntity;
    
    [SerializeField] protected PointSpawn _pointSpawn;
    [SerializeField] protected T _entity;
    [SerializeField] protected int _countEntity;
    
    protected Pool<T> _pool = new Pool<T>();
    
    protected virtual void SpawnEntity()
    {
        if (_pool.DisavleObject.Count == 0)
        {
            Create();
        }
    }

    protected virtual T Create()
    {
        T entity = Instantiate(_entity, GetPositionSpawn(), Quaternion.identity);
        entity.gameObject.SetActive(true);
        _pool.EnableObject.Add(entity);
        entity._enable += UpdatePool;
        entity.gameObject.transform.parent = gameObject.transform;

        return entity;
    }
    
    protected virtual Vector3 GetPositionSpawn()
    {
        return _pointSpawn.GetRandomPositionPoint();
    }
    
    private void UpdatePool(bool activeObject,MonoBehaviour monoBehaviour)
    {
        T entity = monoBehaviour as T;  
       
        if (activeObject == true)
        {
            _pool.DisavleObject.Remove(entity);
            _pool.EnableObject.Add(entity);
            UpdatedEntity.Invoke(_pool.EnableObject.Count,_pool.DisavleObject.Count);
            return;
        }
       
        _pool.EnableObject.Remove(entity);
        _pool.DisavleObject.Add(entity);
        UpdatedEntity.Invoke(_pool.EnableObject.Count,_pool.DisavleObject.Count);
    }
}
