using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject _startingButtons;
    [SerializeField] private GameObject _chooseTransport;
    [SerializeField] private GameObject pauseMenu;
    public bool isGameStarted = false;
    void Start()
    {
        _startingButtons.SetActive(true);
        _chooseTransport.SetActive(false);
        Time.timeScale = 0;
    }

    public void ClickOnChooseTransport()
    {
        if (!pauseMenu.activeSelf)
        {
            _chooseTransport.SetActive(!_chooseTransport.activeSelf);
            _chooseTransport.GetComponent<ChooseTransport>().index = 0;
        }
            
    }

    public void ClickOnStart()
    {
        if (ChooseTransport.isVehicleAvailable)
        {
            _startingButtons.SetActive(false);
            _chooseTransport.SetActive(false);
            Time.timeScale = 1;
            isGameStarted = true;
        }
        
    }
}
