using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOne : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("quit");

    }

    public void StartButton()
    {

        SceneManager.LoadScene("Main");
    }

}