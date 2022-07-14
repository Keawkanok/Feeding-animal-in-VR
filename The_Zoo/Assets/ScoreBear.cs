using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBear : MonoBehaviour
{
    public static ScoreBear instance_Bear;

    public Text ScoreText;

    public static float score = 0;

    private int next;


    private void Awake()
    {
        instance_Bear = this;
    }
    void Start()
    {

        next = SceneManager.GetActiveScene().buildIndex + 1;
        ScoreText.text = score.ToString() + "% ค่าความหิว";
        ScoreText.color = Color.red;
    }

    void Update()
    {
     
    }


    public void AddScore()
    {
        if (score == 0)
        {
            score += 10;
            ScoreText.color = Color.red;
        }
        else if (score == 10)
        {
            score += 10;
        }
        else if (score == 20)
        {
            score += 10;
        }
        else if (score == 30)
        {
            score += 10;
        }
        else if (score == 40)
        {
            score += 10;
        }
        else if (score == 50)
        {
            score += 10;
        }
        else if (score == 60)
        {
            score += 10;
        }
        else if (score == 70)
        {
            score += 10;
        }
        else if (score == 80)
        {
            score += 10;
        }
        else if (score == 90)
        {
            score += 10;
            ScoreText.color = Color.green;

        }
        else if (score == 100)
        {
            score = 100;
            ScoreText.color = Color.green;

        }
        else if (score == 100 && ScoreDeer.score == 100)
        {
            score = 100;
            ScoreText.color = Color.green;
            /*int index = Random.Range(0, 2);
            SceneManager.LoadScene(index);*/
            /*SceneManager.LoadScene(next);*/
            /*Debug.Log("score" + score);*/

        }

        ScoreText.text = score.ToString() + "% ค่าความหิว";
    }
    public void NegativeScore()
    {
        if (score == 0 && score == -10)
        {
            score = 0;
            ScoreText.color = Color.red;
        }
        else if (score == 10)
        {
            score -= 10;
        }
        else if (score == 20)
        {
            score -= 10;
        }
        else if (score == 30)
        {
            score -= 10;
        }
        else if (score == 40)
        {
            score -= 10;
        }
        else if (score == 50)
        {
            score -= 10;
        }
        else if (score == 60)
        {
            score -= 10;
        }
        else if (score == 70)
        {
            score -= 10;
        }
        else if (score == 80)
        {
            score -= 10;
        }
        else if (score == 90)
        {
            score -= 10;
        }
        else if (score == 100)
        {
            score -= 10;
            ScoreText.color = Color.red;
        }
        ScoreText.text = score.ToString() + "% ค่าความหิว";
    }
}

