using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallCube : MonoBehaviour
{
    public Rigidbody rb;

    public GameObject Player;

    /*public animator deathAnim; */

    void Update()
    {
        rb.AddForce(0, -5, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            StartCoroutine(killPlayer());
            
            
        }
    }

    IEnumerator killPlayer()
    {
        FindObjectOfType<AudioManager>().Play("Death");
        /* play death animation */
        
        SceneManager.LoadScene("MainMenu");



        yield return 0;
    }

   
}
