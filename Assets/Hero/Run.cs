using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Run : MonoBehaviour
{
    [SerializeField] 
    private AnimationBase _animationBase;
    [SerializeField] 
    private RoutePoint _point;
    
    private UnityEngine.AI.NavMeshAgent _agent;
    private bool _playAnimation = false;
    private bool _runNextPoint = true;
    
    private void Start()
    {
        _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void RunNextPoint()
    {
        Vector3 designatedPlace = _point.GiveNextPositionPoint();
        _agent.SetDestination(designatedPlace);
    }

    public void CheckMoveNext(bool enemisLost)
    {
        if (_runNextPoint != enemisLost)
        {
            _playAnimation = true;
        }
        
        _runNextPoint = enemisLost; 
    }

    private void FixedUpdate()
    {
        if (_agent.hasPath == false && _playAnimation == true)   
        { 
            _animationBase.PlayAnimation(TypeAnimation.Stop);
            _playAnimation = false;
        }

        if (_agent.hasPath == false && _runNextPoint == true)
        {
            _animationBase.PlayAnimation(TypeAnimation.Run);
            RunNextPoint();
        }
    }
    
}
