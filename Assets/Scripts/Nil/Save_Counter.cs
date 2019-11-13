﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Counter : MonoBehaviour
{
    public float saves;

    public AudioClip impact;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            saves += 1;
            audioSource.PlayOneShot(impact, 1F);
        }
    }
}
