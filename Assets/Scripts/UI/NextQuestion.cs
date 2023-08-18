using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextQuestion : MonoBehaviour
{
    [SerializeField] private GameObject[] _pages;
    private int indexer = 0;
    
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextQuestion1()
    {
        _pages[indexer].SetActive(false);
        indexer++;
        _pages[indexer].SetActive(true);
    }

   
}
