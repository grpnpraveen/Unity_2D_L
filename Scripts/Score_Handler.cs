using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using UnityEngine;

public class Score_Handler : MonoBehaviour
{
    public GameObject currentscoreobject;
    public GameObject highestscoreobject;

    private TextMesh currenttext;
    private TextMesh highesttext;

    private int current;
    private int high;

    // Start is called before the first frame update
    void Start()
    {
      
        currenttext = currentscoreobject.GetComponent<TextMesh>();
        highesttext = highestscoreobject.GetComponent<TextMesh>();
        
        currenttext.text = PlayerPrefs.GetString("currentscore");

        current = System.Convert.ToInt32(PlayerPrefs.GetString("currentscore"));

        high = PlayerPrefs.GetInt("highscore");
        
        if (current>high)
        {
            PlayerPrefs.SetInt("highscore",current);
        }
      
        highesttext.text= System.Convert.ToString(PlayerPrefs.GetInt("highscore"));


    }

    
}
