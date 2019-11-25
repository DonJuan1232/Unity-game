using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool WallTouchL = false;
    bool WallTouchR = false;


    public Rigidbody rb;

    public GameObject wallL;
    public GameObject wallR;
    public GameObject player;

    public void right()
    {
        if (WallTouchR == true)
        {
            rb.AddForce(-1500, 1000, 0);
            new WaitForSeconds(0.5f);
            WallTouchR = false;
        }
    }

    public void left()
    {
        if (WallTouchL == true)
        {
            rb.AddForce(1500, 1000, 0);
            new WaitForSeconds(0.5f);
            WallTouchL = false;
        }
    }


    void OnCollisionEnter(Collision hit)
    {
        if (hit.transform.gameObject.name == "wallR" || hit.transform.gameObject.name == "wallR(Clone)")
        {
            WallTouchR = true;
            
        }

        if (hit.transform.gameObject.name == "wallL" || hit.transform.gameObject.name == "wallL(Clone)")
        {
            WallTouchL = true;
            
        }
    }

    



}
