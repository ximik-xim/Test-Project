using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public abstract class LivingEntity : Entity
{
    [SerializeField] 
    private float _maxLive;
    [SerializeField]
    private float _life;
    
    protected float _liveEntity
    {
         get
        {
            return _life;
        }
        private set
        {
            if (_life > 0 && _life != value) 
            {
                _life = value;
                if (_life <= 0)
                {
                    Dead();
                }
            }
        }
    }
    protected override void OnEnable()
    {
        Reset();
        base.OnEnable();
    }
    
    protected virtual void Dead()
    {
        gameObject.SetActive(false);
    } 

    private void Reset()
    {
        _liveEntity = _maxLive;
    }

    public void Kill()
    {
        _liveEntity = 0;
    }

    public void TakeDamage(float damage)
    {
        _liveEntity -= damage;
    }
}
