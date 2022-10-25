using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class ReactionTrigger: MonoBehaviour
{
    public abstract void ReactionInvoke(Collider collider);
}
