using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Net : MonoBehaviour
{
    public float lives;
    public GameObject losePanel;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
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
            Destroy(collision.gameObject);
            lives -= 1;
        }
    }
}
