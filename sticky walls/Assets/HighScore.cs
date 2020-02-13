using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScoreText;
    public float highScore;
    public float currentScore;

    public void Start()
    {
        PlayerPrefs.GetFloat("highScore");
    }

    public void Update()
    {
        if (PlayerPrefs.GetFloat("highScore") > currentScore)
        {
            highScoreText.text = highScore.ToString();
            //You need this to save high score across game sessions
            PlayerPrefs.SetFloat("High Score", highScore);
        }




    }

    public void FixedUpdate()
    {
        currentScore = PlayerPrefs.GetFloat("currentTime");

        

        

    }



}
