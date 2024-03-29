﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical : MonoBehaviour
{

    public GameObject loseText;
    public GameObject Reset;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("touched trigger");
        if (collision.tag == "Player")
        {
            audioSource.Play();
            loseText.SetActive(true);
            Reset.SetActive(true);
            GameOver.IsGameOver = true;
        }
    }
}
