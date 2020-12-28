using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggering_halfScreen : MonoBehaviour
{
    public float movingspeed=19f;
    private Rigidbody2D halfbody;
    private void Start()
    {
        halfbody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            halfbody.velocity = Vector2.up * movingspeed*0.1f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            halfbody.velocity = Vector2.up * movingspeed * 0f;
        }
    }





}
