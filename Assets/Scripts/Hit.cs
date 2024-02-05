using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public AudioSource source;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.Play();
    }
}
