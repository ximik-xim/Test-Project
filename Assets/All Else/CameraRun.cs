using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRun : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    [SerializeField] private Vector3 _cameraPosition;
    [SerializeField] private Vector3 _cameraForward;


    private void Update()
    {
        Vector3 cameraPosition = _hero.transform.position - _hero.transform.forward + _cameraPosition;
        transform.position = cameraPosition;
        
        Vector3 cameraForward = _hero.transform.forward + _cameraForward;
        transform.forward = cameraForward;
    }

    
}
