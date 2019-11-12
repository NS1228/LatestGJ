using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_scorelives : MonoBehaviour
{
    public GameObject net;
    public GameObject gloves;

    public float score;
    public float lives;

    public TextMeshProUGUI livesText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;

    // Start is called before the first frame update
    void Start()
    {
        //livesText = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        lives = net.GetComponent<Net>().lives;
        livesText.text = "Lives:" + lives;

       score = gloves.GetComponent<Save_Counter>().saves;
       scoreText.text = "Score:" + score;
       finalScoreText.text = "Score:" + score;




    }
}
