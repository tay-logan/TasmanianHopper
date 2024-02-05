using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        PlayerPrefs.SetInt("tumbleweed", 0);
        PlayerPrefs.SetInt("gameScore", 0);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("Game");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void AboutButton()
    {
        SceneManager.LoadScene("About");
    }
}
