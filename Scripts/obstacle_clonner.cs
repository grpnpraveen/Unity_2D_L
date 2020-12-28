using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_clonner : MonoBehaviour
{
    public GameObject obstacle_prefab;
    public GameObject obstacle_position;

    public GameObject obstacle2_prefab;
    public GameObject obstacle2_position;

    public GameObject colorchanger_prefab;
    public GameObject colorchanger_position;

    public GameObject points_prefab;
    public GameObject points_position;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Spwan")
        {
            int x = Random.Range(0,2);
            if (x==0)
            {
                Instantiate(obstacle_prefab, obstacle_position.transform.position, obstacle_position.transform.rotation);
                Instantiate(colorchanger_prefab, colorchanger_position.transform.position, colorchanger_position.transform.rotation);
                Instantiate(points_prefab, obstacle_position.transform.position, obstacle_position.transform.rotation);

            }
            else if(x==1)
            {
                Instantiate(obstacle2_prefab, obstacle2_position.transform.position, obstacle2_position.transform.rotation);
                Instantiate(colorchanger_prefab, colorchanger_position.transform.position, colorchanger_position.transform.rotation);
                Instantiate(points_prefab, obstacle2_position.transform.position, obstacle2_position.transform.rotation);

            }
        }
    }
}
