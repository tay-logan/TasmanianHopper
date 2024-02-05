using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject platform;
    public GameObject breakablePlatform;
    public GameObject deathPlatform;
    public int count = 1000;
    public GameObject Karl;
    public int score;
    public TMPro.TextMeshProUGUI scoreText;
    public GameObject message;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Karl.SetActive(false);
        PlayerPrefs.SetInt("gameScore", score);
        message.SetActive(false);
        ShowCursor();
        SceneManager.LoadScene("GameOver");
    }

    void Awake()
    {
        PlayerPrefs.SetInt("tumbleweed", 0);
        score = 0;
    }

    void Start()
    {
        Vector3 spawn = new Vector3(0, 4, 0);

        for (int i = 0; i < count; i++)
        {
            int platformType = Random.Range(0, 12);
            spawn.y += Random.Range(3f, 7f);
            spawn.x = Random.Range(-10f, 10f);

            if (platformType == 3 || platformType == 9)
            {
                Instantiate(breakablePlatform, spawn, Quaternion.identity);
            }
            else if (platformType == 5)
            {
                Instantiate(deathPlatform, spawn, Quaternion.identity);
            }
            else
            {
               Instantiate(platform, spawn, Quaternion.identity); 
            }
            
        }
    }
    void Update()
    {
        scoreText.text = score.ToString();
        if (Karl.transform.position.y > score)
        {
            score = (int)Karl.transform.position.y;
        }
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
