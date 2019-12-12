using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeOnGameOver : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (GameOver.IsGameOver)
        rigidbody.simulated = false;
        
    }
}
