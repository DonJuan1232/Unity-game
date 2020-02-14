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
        if (currentScore > highScore)
        {

            currentScore = highScore;

            highScoreText = GetComponent<Text>();

            highScoreText.text = highScore.ToString();
            
            PlayerPrefs.SetFloat("highScore", highScore);
        }




    }

    public void FixedUpdate()
    {
        currentScore = PlayerPrefs.GetFloat("currentTime");

        
        highScore = PlayerPrefs.GetFloat("highScore");


    }



}
