using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public bool playSound;
    public float soundTimer;   
    public AudioClip kick;
    AudioSource audioSource;

    public GameObject gloves;

    public float force;
    public float timer;

    public float speed;
    public float xPos;
    public float yPos;
    public float zPos;
    public Vector3 desiredPos;

    public float deathTimer;
    void Start()
    {
        deathTimer = 1000;
        xPos = Random.Range(-9.5f, 9.5f);
        yPos = Random.Range(-4.5f, 5.5f);
        zPos = Random.Range(-7f, -7f);

        desiredPos = new Vector3(xPos, yPos, zPos);
        timer = Time.timeSinceLevelLoad + 1.5f;

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad >= timer)
        {
            Shoot();
        }
        speed = Random.Range(1.5f, 2.0f);

        if(Time.timeSinceLevelLoad >= deathTimer)
        {
            Destroy(gameObject);
        }

    }

    public void Shoot()
    {
        if(Time.timeSinceLevelLoad >= soundTimer)
        {
            audioSource.PlayOneShot(kick, 1F);
            soundTimer = Time.timeSinceLevelLoad + 10f;
            
        }
       
        transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
        if (Vector3.Distance(transform.position, desiredPos) <= 0.01f)
        {
            xPos = Random.Range(-4.5f, 4.5f);
            desiredPos = new Vector3(xPos, yPos, zPos);

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Glove")
        {
            gloves.GetComponent<Save_Counter>().saves += 1;
            timer = 99999;

            Vector3 dir = collision.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            GetComponent<Rigidbody>().AddForce(dir * force);
            this.GetComponent<Rigidbody>().useGravity = true;
            deathTimer = Time.timeSinceLevelLoad + 2f;
         
        }
    }
}

