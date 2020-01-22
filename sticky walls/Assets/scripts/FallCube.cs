using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallCube : MonoBehaviour
{
    public Rigidbody rb;
    void Update()
    {
        rb.AddForce(0, -5, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            FindObjectOfType<AudioManager>().Play("Death");

            new WaitForSeconds(2);  
            SceneManager.LoadScene("MainMenu");
            
            
        }
    }

   
}
