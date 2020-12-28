using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oncollision : MonoBehaviour
{
    private SpriteRenderer playersprite;//setting color 
    public GameObject score;//score object
    private TextMesh scoretext;//score text in dialog box

    public ParticleSystem star;
    public ParticleSystem plusone;

    public ParticleSystem red;
    public ParticleSystem blue;
    public ParticleSystem green;
    public ParticleSystem yellow;

    private SpriteRenderer playersprite2;
    private Rigidbody2D playerbody;
    public void gameover()
    {
        SceneManager.LoadScene("GameOver_Scene");

    }

    private void Start()
    {

        scoretext = score.GetComponent<TextMesh>();
        playersprite2 = GetComponent<SpriteRenderer>();
        playerbody = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            if (collision.name != name)
            {
                playersprite2.enabled = false;
                if (name == "red")
                {
                    red.Play();
                }
                else if (name == "green")
                {
                    green.Play();
                }
                else if (name == "blue")
                {
                    blue.Play();
                }
                else
                {
                    yellow.Play();
                }
                PlayerPrefs.SetString("currentscore", scoretext.text);
                playerbody.constraints = RigidbodyConstraints2D.FreezePositionY;


                Invoke("gameover", 1);

            }
        }
        //color changing
        else if (collision.tag == "ColorChanger")
        {
            int d = Random.Range(0, 2);

            if (System.Convert.ToInt32(scoretext.text) > 50)
            {
                int p = Random.Range(0, 2);
                if (d == 0)
                {
                    if (p != 0)
                    {
                        scoretext.text = System.Convert.ToString(System.Convert.ToInt32(scoretext.text) + 1);

                    }


                }
                else
                {
                    Destroy(collision.gameObject);
                }
            }


            Destroy(collision.gameObject);

            if (name == "red")
            {
                int x = Random.Range(0, 3);
                playersprite = GetComponent<SpriteRenderer>();
                switch (x)
                {

                    case 0:
                        playersprite.color = new Color(0f, 1f, 0f);
                        name = "green";
                        break;
                    case 1:
                        playersprite.color = new Color(0f, 0f, 1f);
                        name = "blue";
                        break;
                    case 2:
                        playersprite.color = new Color(1f, 0.75f, 0f);
                        name = "yellow";
                        break;
                };
            }
            else if (name == "green")
            {
                int x = Random.Range(0, 3);
                playersprite = GetComponent<SpriteRenderer>();
                switch (x)
                {
                    case 0:
                        playersprite.color = new Color(1f, 0f, 0f);
                        name = "red";
                        break;

                    case 1:
                        playersprite.color = new Color(0f, 0f, 1f);
                        name = "blue";
                        break;
                    case 2:
                        playersprite.color = new Color(1f, 0.75f, 0f);
                        name = "yellow";
                        break;
                };
            }
            else if (name == "yellow")
            {
                int x = Random.Range(0, 3);
                playersprite = GetComponent<SpriteRenderer>();
                switch (x)
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

                };
            }
            else
            {
                int x = Random.Range(0, 3);
                playersprite = GetComponent<SpriteRenderer>();
                switch (x)
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
                        playersprite.color = new Color(1f, 0.75f, 0f);
                        name = "yellow";
                        break;
                };
            }

        }
        else if (collision.tag == "Points")
        {
            scoretext.text = System.Convert.ToString(System.Convert.ToInt32(scoretext.text) + 1);
            star.Play();
            Destroy(collision.gameObject);
            plusone.Play();
            if (System.Convert.ToInt32(scoretext.text) > 1000)
            {
                scoretext.color = new Color(255f, 0f, 0f);


            }



        }
        else if (collision.tag == "bug")
        {
            if (System.Convert.ToInt32(scoretext.text) > 0)
            {
                SceneManager.LoadScene("GameOver_Scene");
            }
        }
    }
}

