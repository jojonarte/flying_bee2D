using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControll : MonoBehaviour {
    public int highScore = 0;
    public int currScore = 0;
	// Use this for initialization
	void Start () {
	
        if(PlayerPrefs.HasKey("highScore")) {

            highScore = PlayerPrefs.GetInt("highScore");

        } else {

            PlayerPrefs.SetInt("highScore",0);

        }

        Debug.Log("High score is : "+highScore);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddScore(){

        //inc curr score
        //check if curr higher than high score
        //replace high score if true

        currScore++;

        if(currScore>highScore){

            PlayerPrefs.SetInt("highScore",currScore);
         //   highScore = currScore;

        }

    }

    void FixedUpdate()
    {
        GameObject.Find("ScoreText").GetComponent<Text>().text = currScore.ToString();
    }
}
