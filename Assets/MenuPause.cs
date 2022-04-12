using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    [SerializeField] 
    private GameObject pauseMenuUI;

    [SerializeField] 
    private bool isPaused;

    private void update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        if (isPaused)
        {
            ActiveMenu();
        }

        else
        {
            DesactiveMenu();
        }
    }

    void ActiveMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

   public void DesactiveMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }

    public void QuitGame()
    {

        Debug.Log("Quit");
        Application.Quit();

    }

}
