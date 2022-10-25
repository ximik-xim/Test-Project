using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PointSpawn : MonoBehaviour
{
    [SerializeField] 
    private List<Vector3> _position = new List<Vector3>();

    public int GetCoutnPoint()
    {
        return _position.Count;
    }

    public Vector3 GetPositionPoint(int id)
    {
        return _position[id];
    }

    public Vector3 GetRandomPositionPoint()
    {
        int positionSpawn = Random.Range(0, _position.Count);
        return _position[positionSpawn];
    }

    private void Awake()
    {
        foreach (Transform t in transform)
        {
            _position.Add(t.position);
        }
    }
    private void OnDrawGizmos()
    {

        foreach (Transform t in transform)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(t.position,1f);
        }
    }
}
