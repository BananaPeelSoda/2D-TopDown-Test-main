using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(_mainMenuCanvas == null) { return; }
        if(SceneManager.GetActiveScene() != null) {_mainMenuCanvas.SetActive(false); return ; }
        Time.timeScale = 0f;
    }
    public void playButton()
    {
        Time.timeScale = 1f;
    }
    public void pauseButton()
    {
        Time.timeScale = 0f;
    }
    public void resumeButton()
    {
        Time.timeScale = 1f;
    }
    public void QuitGame()
    { 
        Application.Quit();
    }
    // Update is called once per frame
    }

