using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject message;
    public float force = 20f;
    public Transform Karl;
    public AudioSource source;

    void Update()
    {
        if (transform.position.y < Karl.position.y-10)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.name == "deathplatform(Clone)")
        {
            PlayerPrefs.SetInt("tumbleweed", 1);
            GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");
            for(int i = 0; i < platforms.Length; i++)
            {
                Destroy(platforms[i]);
            }
            message.SetActive(true);
            Karl.transform.position = new Vector3(Karl.transform.position.x, Karl.transform.position.y - (float)0.5, Karl.transform.position.z);
        }

        if (collision.relativeVelocity.y <= 0f && gameObject.name == "breakable platform(Clone)")
        {
            source.Play();
            InvokeRepeating("Fall", 0, 0.04f);
            Invoke("EndFall", 4);
        }
        
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D Karl = collision.gameObject.GetComponent<Rigidbody2D>();

            if (Karl != null)
            {
                Vector2 v = Karl.velocity;
                v.y = force;
                Karl.velocity = v;
            }
        }
    }

    void Fall()
    {
        if (transform.position.y > 100)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y*(float)0.89, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y*(float)0.99, transform.position.z);
        }
    }

    void EndFall()
    {
        Destroy(gameObject);
        CancelInvoke();
    }
}
