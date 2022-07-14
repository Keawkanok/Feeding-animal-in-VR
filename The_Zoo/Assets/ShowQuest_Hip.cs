using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ShowQuest_Hip : MonoBehaviour, IPointerClickHandler

{
    public GameObject UIObject_text;
    public GameObject UIObject_Food;
    public GameObject UIObject_GetQuest;

    public Text ScoreText;
    public static float score;



    void Start()
    {
        UIObject_text.SetActive(false);
        UIObject_Food.SetActive(false);
    }

    void Update()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารฮิปโป";

        if (score == 1)
        {
            Debug.Log("score " + score);
            ScoreText.text = score + "/1 ให้อาหารฮิปโป";
            ScoreText.color = Color.green;
            UIObject_Food.SetActive(true);
            /*Destroy(this.UIObject_Food, 7f);*/
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        UIObject_text.SetActive(true);
        UIObject_Food.SetActive(true);
        StartCoroutine("WaitTextQuest");
        Destroy(this.UIObject_GetQuest, 5f);
        Destroy(this.UIObject_text, 5f);
    }

    IEnumerator WaitTextQuest()
    {
        yield return new WaitForSeconds(5);
        UIObject_text.SetActive(false);
        /*UIObject_Food.SetActive(false);*/
        UIObject_GetQuest.SetActive(false);
    }
}
