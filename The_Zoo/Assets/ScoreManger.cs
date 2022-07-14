using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManger : MonoBehaviour
{
    public static ScoreManger instance;

    public Text ScoreText;

    float score = 0;

    private int next;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
        ScoreText.text = score.ToString() + " Hunger";
        ScoreText.color = Color.red;
        
    }

    void Update()
    {
       

        if (score == 100 && ScoreBoar.score == 100)
        {
            score = 100;
            ScoreText.color = Color.green;
            /*Debug.Log("score" + score);*/
            SceneManager.LoadScene(next);
        }

       
    }

    
    public void AddScore()
    {
        if (score == 100)
        {
            score = 100;
            ScoreText.color = Color.green;
        }
        score += 10;
        if (score == 100 && ScoreBoar.score == 100)
        {
            score = 100;
            ScoreText.color = Color.green;
            /*Debug.Log("score" + score);*/
            SceneManager.LoadScene(next);

        }

        ScoreText.text = score.ToString() + " Hunger";
    }
}
