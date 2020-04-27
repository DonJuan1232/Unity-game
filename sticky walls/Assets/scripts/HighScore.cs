using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    

    public Text highScoreText;
    public float highScore;
    public float currentScore;

    public void Awake()
    {
        highScoreText = GetComponent<Text>();
    }

    public void Update()
    {
        if (currentScore >= highScore)
        {
            /*Debug.Log("works");
            Debug.Log(highScore + " highscore");
            Debug.Log(highScoreText + " scoreText");*/
            highScore = currentScore;
            currentScore = highScore;
            highScoreText.text = highScore.ToString();
            PlayerPrefs.SetFloat("highScore", highScore);

            PlayerPrefs.DeleteKey("currentTime");

        }


        currentScore = PlayerPrefs.GetFloat("currentTime");

        

        highScore = PlayerPrefs.GetFloat("highScore");


        highScoreText.text = highScore.ToString();

    }

    


    public void Start()
    {
        


        /*Debug.Log(PlayerPrefs.GetFloat("highScore") + " PPhighscore");
        Debug.Log(PlayerPrefs.GetFloat("currentTime") + " currenttime");*/
    }


}
