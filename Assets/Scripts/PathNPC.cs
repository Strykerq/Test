using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathNPC : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Animator _animator;
    [SerializeField] private ScenarioNPC _scenarioNPC;
    private int _currentIndex = 0;
    private Transform targetPoint;
    private const float MIN_DISTANCE = 0.2f;
    AnimationTypes animation;


    
    void Start()
    {
        _scenarioNPC = ScenarioNPC.Instance;
        Invoke("Move", 3f);
    }
    public void Move()
    {        
        if(_currentIndex < _scenarioNPC._checkPoints.Count)
        {
            targetPoint = _scenarioNPC._checkPoints[_currentIndex];
            _animator.SetTrigger("walk");
            _agent.SetDestination(targetPoint.position);           
        }       
    }
    private void Update()
    {                   
            float distance = Vector3.Distance(transform.position, targetPoint.position);           
            if (distance < MIN_DISTANCE && _currentIndex == 0)
            {
                _animator.SetTrigger("sit");
                _currentIndex++;
                Invoke("Move", 7f);
            }
            else if(distance < MIN_DISTANCE && _currentIndex > 0)
            {
                _animator.SetTrigger("dance");
            }         
        
        
    }
}