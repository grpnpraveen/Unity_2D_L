using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startcolor : MonoBehaviour
{
    private SpriteRenderer playersprite;

    public void startcolorchanging()
    {
        int x = Random.Range(0, 4);
        playersprite = GetComponent<SpriteRenderer>();
        switch(x)
        {
            case 0:
                playersprite.color = new Color(1f, 0f, 0f);
                name = "red";
                break;
            case 1:
                playersprite.color = new Color(0f, 1f, 0f);
                name = "green";
                break;
            case 2:
                playersprite.color = new Color(0f, 0f, 1f);
                name = "blue";
                break;
            case 3:
                playersprite.color = new Color(1f, 0.75f, 0f);
                name = "yellow";
                break;
        };
    }
    void Start()
    {
        startcolorchanging();
    }

    
}
