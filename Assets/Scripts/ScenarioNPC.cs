using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioNPC : MonoBehaviour
{
    public static ScenarioNPC Instance;
    public List<Transform> _checkPoints = new List<Transform>();
    [SerializeField] private Transform _parent;
    [SerializeField] private GameObject _npcPrefab;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Spawn();      
    }

    public void Spawn()
    {
        GameObject npc = Instantiate(_npcPrefab, _parent);
    }
}
