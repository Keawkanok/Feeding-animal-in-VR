using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ShowQues_Boar : MonoBehaviour
{
    public GameObject UIObject_textMessage;
    public GameObject UIObject_QuestText;
    public GameObject UIObject_Button;
    public GameObject UIObject_NotFood;

    public Text ScoreText;
    public static float score;

    void Start()
    {
        UIObject_textMessage.SetActive(false);
        UIObject_QuestText.SetActive(false);
    }

    void Update()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารหมูป่า";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารหมูป่า";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }

        if (score == 0)
        {
            Debug.Log("score " + score);
            ScoreText.text = score + "/1 ให้อาหารหมูป่า";
            ScoreText.color = Color.red;
        }
    }

    IEnumerator WaitTextQuest()
    {
        yield return new WaitForSeconds(5);
        UIObject_textMessage.SetActive(false);
        UIObject_Button.SetActive(false);
    }
}
