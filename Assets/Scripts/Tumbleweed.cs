using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumbleweed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("enter");
        GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");

        for(int i = 0; i < platforms.Length; i++)
        {
            Destroy(platforms[i]);
        }
    }
}
