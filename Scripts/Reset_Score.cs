using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Score : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        PlayerPrefs.SetString("highscore", "0");
    }
}
