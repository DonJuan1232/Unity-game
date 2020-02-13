using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameobjects : MonoBehaviour
{

    private void OnCollisionStay(Collision collision)
    {
        
        if (collision.gameObject.tag == "WallL" || collision.gameObject.tag == "WallR" || collision.gameObject.tag == "Coin" || collision.gameObject.tag == "Block")
        {
            
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "WallL" || collision.gameObject.tag == "WallR" || collision.gameObject.tag == "Coin" || collision.gameObject.tag == "Block")
        {
            
            Destroy(collision.gameObject);
        }
    }

}
