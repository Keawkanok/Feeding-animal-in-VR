using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMap2 : SceneManagement
{
    public GameObject UIObject_Lost;
    public GameObject UIObject_Win;
    private float score_all;
    public void Start()
    {
        UIObject_Lost.SetActive(false);
        UIObject_Win.SetActive(false);
    }

    public void Update()
    {
        TotalScoreSceneFirst();
        TotalScoreSceneSecond();
        TotalScoreSceneThird();
    }

    public void TotalScoreSceneFirst()
    {
        score_all = ShowQuest_Goat.scores + ShowQuest_Zebra.score + ShowQuest_Ele.score + ShowQuest_Deer.score + ShowQues_Crocodile.score;
        if (score_all == 5)
        {
            UIObject_Win.SetActive(true);
            StartCoroutine("Win");
            Debug.Log("Win");
            time.finnished = true;
        }
        if (time.timeValue == 0)
        {
            UIObject_Lost.SetActive(true);
            StartCoroutine("Lost");
            Debug.Log("Lost");
        }
    }

    public void TotalScoreSceneSecond()
    {
        score_all = ShowQuest_Deer.score + ShowQues_Lion.score + ShowQuest_Goat.scores + ShowQuest_Rabbit.score + ShowQues_Hip.score;
        if (score_all == 5)
        {
            UIObject_Win.SetActive(true);
            StartCoroutine("Win");
            Debug.Log("Win");
            time.finnished = true;
        }
        if (time.timeValue == 0)
        {
            UIObject_Lost.SetActive(true);
            StartCoroutine("Lost");
        }
    }

    public void TotalScoreSceneThird()
    {
        score_all = ShowQues_Sheep.score + ShowQues_Bear.score + ShowQues_Rhin.score + ShowQues_Boar.score + ShowQues_Lion.score;
        if (score_all == 5)
        {
            UIObject_Win.SetActive(true);
            StartCoroutine("Win");
            Debug.Log("Win");
            time.finnished = true;
        }
        if (time.timeValue == 0)
        {
            UIObject_Lost.SetActive(true);
            StartCoroutine("Lost");
            Debug.Log("Lost");
        }
    }
    public IEnumerator Lost()
    {
        yield return new WaitForSeconds(10);
        SceneSix();
        UIObject_Lost.SetActive(false);
        UIObject_Win.SetActive(false);
        score_all = 0;
        ShowQuest_Deer.score = 0;
        ShowQues_Lion.score = 0;
        ShowQuest_Goat.scores = 0;
        ShowQuest_Rabbit.score = 0;
        ShowQues_Rhin.score = 0;
    }
    public IEnumerator Win()
    {
        yield return new WaitForSeconds(10);
        SceneZero();
        ResetScoreM1();
        UIObject_Lost.SetActive(false);
        UIObject_Win.SetActive(false);
        score_all = 0;
        ShowQuest_Deer.score = 0;
        ShowQues_Lion.score = 0;
        ShowQuest_Goat.scores = 0;
        ShowQuest_Rabbit.score = 0;
        ShowQues_Rhin.score = 0;
    }
}
