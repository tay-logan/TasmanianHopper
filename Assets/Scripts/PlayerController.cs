using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D Karl;
    private float xMovement;
    // Start is called before the first frame update
    void Awake()
    {
        Karl = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal") * speed;
    }

    private void FixedUpdate()
    {
        Vector2 v = Karl.velocity;
        v.x = xMovement;
        Karl.velocity = v;
    }
}
