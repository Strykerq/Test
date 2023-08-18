using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statictics : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _statictics;
    public void GoToStatictics()
    {
        _mainMenu.SetActive(false);
        _statictics.SetActive(true);   //CREATE MAINMENU MANAGER
    }
}
