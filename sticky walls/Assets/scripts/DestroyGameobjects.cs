using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameobjects : MonoBehaviour
{

    private void OnCollisionStay(Collision collision)
    {
        
        if (collision.gameObject.tag == "WallL" || collision.gameObject.tag == "WallR")
        {
            Debug.Log("works");
            Destroy(collision.gameObject);
        }
    }

}
