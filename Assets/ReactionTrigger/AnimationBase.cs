using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBase : MonoBehaviour
{
   [SerializeField] private Animator _animator;
   [SerializeField] private CustomDictionary<TypeAnimation, AnimationClip> _baseClip;

   private event Action _endAnaimation;
   private TypeAnimation _lastTypeAnimation;
   private void Awake()
   {
      _baseClip.Initialization();
   }

   public void PlayAnimation(TypeAnimation typeAnimation, Action endAnimation = null)
   {
      if (_lastTypeAnimation != typeAnimation)
      {
         _animator.CrossFade(_baseClip[typeAnimation].name,0.1f);
      }
      else
      {
         _animator.Play(_baseClip[typeAnimation].name,-1,0f);
      }

      _lastTypeAnimation = typeAnimation;
      
      _endAnaimation = endAnimation;
   }

   public void EndAninmation()
   {
      if (_endAnaimation != null)
      {
         _endAnaimation.Invoke();   
      }
   }
}
