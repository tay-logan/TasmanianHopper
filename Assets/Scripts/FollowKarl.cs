using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowKarl : MonoBehaviour
{
    public Transform Karl;
    private int tumbleweed;

    void Update()
    {
        tumbleweed = PlayerPrefs.GetInt("tumbleweed");
        if (Karl.position.y > transform.position.y && tumbleweed != 1)
        {
            Vector3 updatedPosition = new Vector3(transform.position.x, Karl.position.y - 1, transform.position.z);
            transform.position = updatedPosition;
        }
    }

    void LateUpdate()
    {
        
    }
}
