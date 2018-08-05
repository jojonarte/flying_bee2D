using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class titleController : MonoBehaviour
{
    public int highScore = 0;

    // Use this for initialization
    void Start()
    {

        if (PlayerPrefs.HasKey("highScore"))
        {

            highScore = PlayerPrefs.GetInt("highScore");

        }
        else
        {

            PlayerPrefs.SetInt("highScore", 0);

        }

        GameObject.Find("highScoreText").GetComponent<Text>().text = "Your High Score is: " + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void StartGame()
    {
        Application.LoadLevel("playscene");

    }

}

