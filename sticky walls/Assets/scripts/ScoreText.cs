using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{
    Text text;
    public static int coinAmount;

    private void Start()
    {
        text = GetComponent<Text>();
        coinAmount = PlayerPrefs.GetInt("CoinAmount", coinAmount);
    }

    private void Update()
    {
        text.text = coinAmount.ToString();
        PlayerPrefs.SetInt("CoinAmount", coinAmount);
    }

    /*private void Awake()  
    {
        PlayerPrefs.DeleteAll();
    }*/

}
