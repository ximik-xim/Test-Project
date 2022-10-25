using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    [SerializeField] private AnimationBase _animationBase;
    
    [SerializeField] private float _fireDamage;
    [SerializeField] private float _maxDistance;
    
    private bool _fire = false;
    private Transform _heroTransform;
    private Tween tween;
    private void Start()
    {
        _heroTransform = _hero.transform;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_fire == true)
            {
                FireEntity();
            }
        }
    }

    private void FireEntity()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, _maxDistance)) 
        {
            Vector3 direction = hit.point - _heroTransform.transform.position;
            direction.y = direction.z;
            direction.z = 0;

            float angel = Vector2.SignedAngle(direction, Vector2.up);

            tween = _heroTransform.DORotate(new Vector3(0, angel, 0), 1);
            tween.onComplete += delegate
            {
                if (_fire == true)
                {
                    _animationBase.PlayAnimation(TypeAnimation.Fire, delegate { TakeDamageEntity(hit); });    
                }
            };
        }
    }
    private void TakeDamageEntity(RaycastHit hit)
    {
        if (hit.collider.TryGetComponent<LivingEntity>(out LivingEntity entity))
        {
            entity.TakeDamage(_fireDamage);
        }
    }
    
    public void CheckFire(bool entity)
    {
        _fire = !entity;
    }
}
