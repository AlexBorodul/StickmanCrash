using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paused : MonoBehaviour
{
    [SerializeField]
    GameObject pause;
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject chooseTransport;
    void Start()
    {
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void PauseOn()
    {
        
        if (chooseTransport.activeSelf)
        {
            buttonStart.GetComponent<StartGame>().ClickOnChooseTransport();
        }
        pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseOff()
    {
        pause.SetActive(false);
        if(buttonStart.GetComponent<StartGame>().isGameStarted)
            Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
}
