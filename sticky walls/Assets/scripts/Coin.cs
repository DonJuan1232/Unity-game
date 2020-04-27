using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{

    int coin;


    private void Start()
    {
        coin = 50;
    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Coin")
        {
            ScoreText.coinAmount += coin;
            FindObjectOfType<AudioManager>().Play("coin");
            Destroy(collision.gameObject);

        }
    }

    
}
