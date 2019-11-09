using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Spawn : MonoBehaviour
{ 
    public float currentBalls;
    public float spawnSpeed;

    public float interval;

    public void Update ()
    {
        SpawnBall();
        if(currentBalls >= 0 && currentBalls < 10)
        {
            spawnSpeed = 0;
        }

        if(currentBalls >= 10 && currentBalls < 20)
        {
            spawnSpeed = 1;
        }
        if (currentBalls >= 20 && currentBalls < 30)
        {
            spawnSpeed = 2;
        }
        if (currentBalls >= 30 && currentBalls < 40)
        {
            spawnSpeed = 3;
        }
        if (currentBalls >= 40 && currentBalls < 50)
        {
            spawnSpeed = 4;
        }
        if (currentBalls >= 50 )
        {
            spawnSpeed = 5;
        }
    }
    public GameObject ball;
    void SpawnBall()
    {
        if (spawnSpeed == 0 && Time.time >= interval)
        {
            Vector3 position = new Vector3(Random.Range(-23, 23), -4.5f, Random.Range(13, 60));
            Instantiate(ball, position, Quaternion.identity);
            currentBalls += 1;
            interval = Time.time + 3f;
        }

        if (spawnSpeed == 1 && Time.time >= interval)
        {
            Vector3 position = new Vector3(Random.Range(-23, 23), -4.5f, Random.Range(13, 60));
            Instantiate(ball, position, Quaternion.identity);
            currentBalls += 1;
            interval = Time.time + 2.5f;
        }
        if (spawnSpeed == 2 && Time.time >= interval)
        {
            Vector3 position = new Vector3(Random.Range(-23, 23), -4.5f, Random.Range(13, 60));
            Instantiate(ball, position, Quaternion.identity);
            currentBalls += 1;
            interval = Time.time + 2f;
        }
        if (spawnSpeed == 3 && Time.time >= interval)
        {
            Vector3 position = new Vector3(Random.Range(-23, 23), -4.5f, Random.Range(13, 60));
            Instantiate(ball, position, Quaternion.identity);
            currentBalls += 1;
            interval = Time.time + 1.5f;
        }
        if (spawnSpeed == 4 && Time.time >= interval)
        {
            Vector3 position = new Vector3(Random.Range(-23, 23), -4.5f, Random.Range(13, 60));
            Instantiate(ball, position, Quaternion.identity);
            currentBalls += 1;
            interval = Time.time + 1f;
        }
        if (spawnSpeed == 5 && Time.time >= interval)
        {
            Vector3 position = new Vector3(Random.Range(-23, 23), -4.5f, Random.Range(13, 60));
            Instantiate(ball, position, Quaternion.identity);
            currentBalls += 1;
            interval = Time.time + 0.5f;
        }
    }
}
