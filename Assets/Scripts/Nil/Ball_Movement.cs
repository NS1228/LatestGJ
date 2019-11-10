using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public float force;
    public float timer;

    public float speed = 3.0f;
    public float xPos;
    public float yPos;
    public float zPos;
    public Vector3 desiredPos;
    void Start()
    {
        
        xPos = Random.Range(-8.5f, 8.5f);
        yPos = Random.Range(-4.5f, 5.5f);
        zPos = Random.Range(-7f, -7f);

        desiredPos = new Vector3(xPos, yPos, zPos);
        timer = Time.time + 1.5f;
    }

    void Update()
    {
        if (Time.time >= timer)
        {
            Shoot();
        }
        speed = Random.Range(3.0f, 4.0f);

    }

    public void Shoot()
    {
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
            timer = 99999;

            Vector3 dir = collision.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the player
            GetComponent<Rigidbody>().AddForce(dir * force);
            this.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}

