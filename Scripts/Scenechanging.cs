using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scenechanging : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Play_Scene");
    }
}
