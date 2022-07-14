using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShowQuest_Ele : MonoBehaviour
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
        ScoreText.text = score.ToString() + "/1 �������ê�ҧ";

        if (score == 1)
        {
            /*Debug.Log("score " + score);*/
            ScoreText.text = score + "/1 �������ê�ҧ";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);

        }

        if (score == 0)
        {
            /*Debug.Log("score " + score);*/
            ScoreText.text = score + "/1 �������ê�ҧ";
            ScoreText.color = Color.red;
        }
    }


 
    IEnumerator WaitTextQuest()
    {
        yield return new WaitForSeconds(5);
        UIObject_text.SetActive(false);
        /*UIObject_Food.SetActive(false);*/
        UIObject_GetQuest.SetActive(false);
    }
}
