using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Net : MonoBehaviour
{
    public float lives;
    public GameObject losePanel;

    public AudioClip lose;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0)
        {
            Time.timeScale = 0;
            losePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            audioSource.PlayOneShot(lose, 1F);
            Destroy(collision.gameObject);
            lives -= 1;
        }
    }
}
