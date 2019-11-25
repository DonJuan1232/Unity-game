using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinite : MonoBehaviour
{
    public GameObject player;
    public GameObject wall1;
    public GameObject wall2;

    public Vector3 playerPos;

    void Update()
    {

        playerPos = player.transform.position;

        if (playerPos.y == 15f)
        {
            Instantiate(wall1, new Vector3(-8.03f, 35, 18.68f), Quaternion.identity);

            Instantiate(wall2, new Vector3(8.03f, 35, 18.68f), Quaternion.identity);
        }
    }
}
