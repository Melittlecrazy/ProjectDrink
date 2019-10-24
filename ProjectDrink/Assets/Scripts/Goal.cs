using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// when ball touches goal, you win
/// </summary>
public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("touched trigger");
        if (collision.tag == "Player")
        {
            Debug.Log("player entered goal!");
        }
    }
}
