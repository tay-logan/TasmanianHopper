using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject Karl;
    public GameObject message;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(Karl);
        message.SetActive(false);
        SceneManager.LoadScene("GameOver");
    }
}
