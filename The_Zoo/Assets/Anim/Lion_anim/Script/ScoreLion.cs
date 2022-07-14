using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreLion : RandomSceneMapTwo
{
    public static ScoreLion instance_Lion;
    public Text ScoreText;
    public static float score = 0;
    public int next;
    public static float timeSc02 = 100.0f;
    private float TotalScore = 100;
    public static float TimeSave;


    public void Awake()
    {
        instance_Lion = this;
    }

    public void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
        ScoreText.text = score.ToString() + "% เพิ่มค่าพลัง";
        ScoreText.color = Color.red;
    }

    public void Update()
    {
        timeSc02 += Time.deltaTime;
        TimeSave = timeSc02;
    }

    public void AddScore()
    {
        for (int i = 1; i <= 4; i++)
        {
            if (score != TotalScore)
            {
                score += i;
                if (score == TotalScore)
                {
                    ScoreText.color = Color.green;
                    if (score == TotalScore && ScoreZebra.score == TotalScore)
                    {
                        ScoreText.color = Color.green;
                        if (ScoreBoar.score == 100 && ScoreDeer.score == 100)
                        {
                            RandomSceneMapTwos();
                        }
                        else if (ScoreBoar.score == 0 && ScoreDeer.score == 0)
                        {
                            SceneManager.LoadScene(1);
                        }
                    }
                }
            }
        }
        ScoreText.text = score.ToString() + "% เพิ่มค่าพลัง";
    }

    public void NegativeScore()
    {
        for (int i = 1; i <= 4; i++)
        {
            if (score != 0)
            {
                score -= i;
                ScoreText.color = Color.red;
                if (score == 0 && score == -10)
                {
                    score = 0;
                    ScoreText.color = Color.red;
                }
            }
        }
        ScoreText.text = score.ToString() + "% เพิ่มค่าพลัง";
    }
}
