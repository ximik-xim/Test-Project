using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemi : LivingEntity
{
    [SerializeField] private AnimationBase _animationBase;

    protected override void Dead()
    {
        _animationBase.PlayAnimation(TypeAnimation.Dead,base.Dead);
    }
}
