using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool WallTouchL = false;
    bool WallTouchR = false;

    public Vector3 PlayerMove;

    public Rigidbody rb;

    public GameObject wallL;
    public GameObject wallR;
    public GameObject player;
    public GameObject wallLClone;
    public GameObject wallRClone;

    public static int veloL = 1500;
    public static int veloR = -1500;

    public int MoveDown = 150;
    public void right()
    {
        if (WallTouchR == true)
        {
            rb.AddForce(veloR, 0, 0);
                       
            FindObjectOfType<AudioManager>().Play("Jump");
            new WaitForSeconds(0.5f);
            WallTouchR = false;
        }
    }
    
    public void left()
    {
        if (WallTouchL == true)
        {
            rb.AddForce(veloL, 0, 0);
            
            FindObjectOfType<AudioManager>().Play("Jump");
            new WaitForSeconds(0.5f);
            WallTouchL = false;
        }
    }


    void OnCollisionEnter(Collision hit)
    {
        if (hit.transform.gameObject.tag == "WallR")
        {
            WallTouchR = true;
            
        }

        if (hit.transform.gameObject.tag == "WallL")
        {
            WallTouchL = true;
            
        }

        

    }

    




}
