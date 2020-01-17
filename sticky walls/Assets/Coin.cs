using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.tag == "Coin")
        {
            Debug.Log("coin");
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
