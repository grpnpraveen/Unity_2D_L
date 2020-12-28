using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int x;
    public float speed;


    void Update()
    {
        if(x==1)
        {
            transform.Rotate(Vector3.back,speed*Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.forward,speed*Time.deltaTime);
        }
    }
}
