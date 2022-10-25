using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoutePoint : MonoBehaviour
{

    private List<Vector3> _position = new List<Vector3>();
    private int _currentPoint = 0;
    private int _maxPoint;
    

    private void Awake()
    {
        foreach (Transform t in transform)
        {
            _position.Add(t.position);
        }

        _maxPoint = transform.childCount - 1;
    }

    public Vector3 GiveNextPositionPoint()
    {
        if (_currentPoint < _maxPoint)
        {
            _currentPoint += 1;    
        }

        return _position[_currentPoint];
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        
        foreach (Transform t in transform)
        {
            Gizmos.DrawWireSphere(t.position,1f);
        }
       
        Gizmos.color = Color.cyan;
        
        for (int i = 0; i < transform.childCount - 1 ; i++)
        {
            Vector3 PositionA = transform.GetChild(i).position;
            Vector3 PositionB = transform.GetChild(i + 1).position;
            Gizmos.DrawLine(PositionA,PositionB);
        }
        
    }
}
