using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class PlatformEnd : MonoBehaviour, ITypeTrigger
{
    public TypeTrigger GetTypeTrigger()
    {
        return TypeTrigger.Restart;
    }
 
}
