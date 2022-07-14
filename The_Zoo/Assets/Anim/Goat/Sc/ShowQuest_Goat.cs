using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowQuest_Goat : MonoBehaviour
{ 

    public GameObject UIObject_text;
    public GameObject UIObject_Food;
    public GameObject UIObject_GetQuest;
    public GameObject UIObject_NotFood;

    public Text ScoreText;
    public static float scores;

    void Start()
    {
        UIObject_text.SetActive(false);
        UIObject_Food.SetActive(false);
    }

    void Update()
    {

        ScoreText.text = scores + "/1 ให้อาหารแพะ";

        if (scores == 1)
        {
            ScoreText.text = scores + "/1 ให้อาหารแพะ";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
        }

        if (scores == 0)
        {
            ScoreText.text = scores + "/1 ให้อาหารแพะ";
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
