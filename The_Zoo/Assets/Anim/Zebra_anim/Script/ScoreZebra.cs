using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreZebra : RandomSceneMapTwo
{
    public static ScoreZebra instance_Zebra;
    public Text ScoreText;
    public static float score = 0;
    private float TotalScore = 100;
    private int next;

    private void Awake()
    {
        instance_Zebra = this;
    }
    void Start()
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
                    if (score == 100 && ScoreLion.score == 100)
                    {
                        score = 100;
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
