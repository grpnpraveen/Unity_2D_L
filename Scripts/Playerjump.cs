using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerjump : MonoBehaviour
{
    public float jumpspeed = 10f;
    private Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
    }
   

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            body.velocity = Vector2.up * jumpspeed;
        }
    }
}
