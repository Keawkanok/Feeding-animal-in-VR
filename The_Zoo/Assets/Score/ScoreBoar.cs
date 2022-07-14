using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreBoar : RandomSceneMapTwo
{
    public static ScoreBoar instance_Boar;
    public Text ScoreText;
    public static float score = 0;
    private float TotalScore = 100;
    public static float timeSc01 = 100;

    public void Awake()
    {
        instance_Boar = this;
    }
    public void Start()
    {
        ScoreText.text = score.ToString() + "% เพิ่มค่าพลัง";
        ScoreText.color = Color.red;
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
                    if (score == TotalScore && ScoreDeer.score == TotalScore)
                    {
                        ScoreText.color = Color.green;
                        if (ScoreLion.score == 100 && ScoreZebra.score == 100)
                        {
                            RandomSceneMapTwos();
                        }
                        else if (ScoreLion.score == 0 && ScoreZebra.score == 0)
                        {
                            SceneManager.LoadScene(2);
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

