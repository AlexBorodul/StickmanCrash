using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject _startingButtons;
    [SerializeField] private GameObject _chooseTransport;
    void Start()
    {
        _startingButtons.SetActive(true);
        _chooseTransport.SetActive(false);
        Time.timeScale = 0;
    }

    public void ClickOnChooseTransport()
    {
        _chooseTransport.SetActive(true);
    }

    public void ClickOnStart()
    {
        _startingButtons.SetActive(false);
        _chooseTransport.SetActive(false);
        Time.timeScale = 1;
    }
}
