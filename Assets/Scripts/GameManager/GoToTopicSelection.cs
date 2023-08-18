using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToTopicSelection : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _topicMenu;
   public void GoToTopics()
    {
        _mainMenu.SetActive(false);
        _topicMenu.SetActive(true);                //CREATE MAINMENU MANAGER
    }
}
