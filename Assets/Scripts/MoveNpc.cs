using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveNpc : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Animator _animator;
    void Start()
    {
        GameObject checkPoint = GameObject.FindGameObjectWithTag("CheckPoint");
        _agent.SetDestination(checkPoint.transform.position);
    }

    public void StartMove()
    {
        //AnimationPropertyObject animationPropertyObject;
       // _animator.SetTrigger(animationPropertyObject.AnimationNPC.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
