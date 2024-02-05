using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public TMPro.TextMeshProUGUI score;
    private int finalScore;
    public TMPro.TextMeshProUGUI label;
    public TMPro.TextMeshProUGUI Hscore;
    private int highScore;


    public void MenuButton()
    {
        ShowCursor();
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitButton()
    {
        PlayerPrefs.SetInt("gameScore", 0);
        Application.Quit();
    }

    public void AboutButton()
    {
        SceneManager.LoadScene("About");
    }

    public void Awake()
    {
        finalScore = PlayerPrefs.GetInt("gameScore");

        highScore = PlayerPrefs.GetInt("highScore");

        if (finalScore > highScore)
        {
            PlayerPrefs.SetInt("highScore", finalScore);
            Hscore.text = finalScore.ToString();
            label.color = Color.green;
            Hscore.color = Color.green;
        }
        else
        {
            Hscore.text = highScore.ToString();
        }
        score.text = finalScore.ToString();
    }

    void ShowCursor()
    {
        if (!Cursor.visible || Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
