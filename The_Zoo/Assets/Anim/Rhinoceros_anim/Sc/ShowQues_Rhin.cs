using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ShowQues_Rhin : MonoBehaviour
{
    public GameObject UIObject_text;
    public GameObject UIObject_Food;
    public GameObject UIObject_GetQuest;
    public GameObject UIObject_NotFood;

    public Text ScoreText;
    public static float score;

    void Start()
    {
        UIObject_text.SetActive(false);
        UIObject_Food.SetActive(false);
    }

    void Update()
    {
        ScoreText.text = score.ToString() + "/1 ���������ô";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ���������ô";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_text.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ���������ô";
            ScoreText.color = Color.red;
        }
    }

    IEnumerator WaitTextQuest()
    {
        yield return new WaitForSeconds(5);
        UIObject_text.SetActive(false);
        UIObject_GetQuest.SetActive(false);
    }
}