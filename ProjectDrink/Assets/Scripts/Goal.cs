using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// when ball touches goal, you win
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject winText;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("touched trigger");
        if (collision.tag == "Player" && !GameOver.IsGameOver)
        {
            audioSource.Play();
            winText.SetActive(true); 
        }
    }
}
