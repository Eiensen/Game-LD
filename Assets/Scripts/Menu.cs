using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject joystickPnl;

    public void OnClickMenuBtn()
    {
       
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }

    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        joystickPnl.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        joystickPnl.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
