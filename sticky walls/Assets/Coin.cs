using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Coin")
        {
            ScoreText.coinAmount += 1;
            Destroy(collision.gameObject);

        }
    }

    
}
