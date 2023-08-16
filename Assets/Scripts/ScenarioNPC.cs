using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioNPC : MonoBehaviour
{
    [SerializeField] private Transform _parent;
    [SerializeField] private GameObject _npcPrefab;
    void Start()
    {
        StartMove();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartMove()
    {

        GameObject npc = Instantiate(_npcPrefab,_parent);
    }
}
