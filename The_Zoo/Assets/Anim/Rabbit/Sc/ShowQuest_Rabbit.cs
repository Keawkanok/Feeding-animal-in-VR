using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShowQuest_Rabbit : MonoBehaviour
{ 
    public GameObject UIObject_text;
    public GameObject UIObject_Food;
    public GameObject UIObject_GetQuest;
    public GameObject UIObject_NotFood;
    public GameObject UIObject_NotFood02;


    public Text ScoreText;
    public static float score;

    void Start()
    {
        UIObject_text.SetActive(false);
        UIObject_Food.SetActive(false);
    }

    void Update()
    {
        ScoreText.text = score.ToString() + "/1 �������á�е���";

        if (score == 1)
        {
            ScoreText.text = score + "/1 �������á�е���";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            Destroy(this.UIObject_NotFood02);
            UIObject_text.SetActive(false);
        }

        if (score == 0)
        {
            ScoreText.text = score + "/1 �������á�е���";
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
