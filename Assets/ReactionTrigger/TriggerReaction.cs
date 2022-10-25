using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerReaction : MonoBehaviour
{
    [SerializeField] 
    private CustomDictionary<TypeTrigger, ReactionTrigger> _reaction;
    
    private void Awake()
    {
        _reaction.Initialization();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<ITypeTrigger>(out ITypeTrigger trigger))
        {
            _reaction[trigger.GetTypeTrigger()].ReactionInvoke(other);
        }
    }
}



