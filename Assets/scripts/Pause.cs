using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public static bool PausedYN = false;

    public GameObject pauseMenuUI;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausedYN)
            {
                Resume();
            }
            else
            {
                Pauseaf();
            }

        }

    }


    public void Resume()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PausedYN = false;


    }


    void Pauseaf()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PausedYN = true;
    }

    public void QuitToMenu()
    {

        SceneManager.LoadScene("Menu");
    }
    public void Reset()
    {
        SceneManager.LoadScene("Main");
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("quit");

    }
}
