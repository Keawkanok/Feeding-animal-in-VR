using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public GameObject UIObject_textMessage;
    public GameObject UIObject_Food;
    public GameObject UIObject_GetQuest;
    public GameObject UIObject_NotFood;

    public Text ScoreText;
    public static float score;

    void Start()
    {
        ShowText();
    }

    public void ShowText()
    {
        UIObject_textMessage.SetActive(false);
        UIObject_Food.SetActive(false);
    }

    void Update()
    {
        Quest_Hip();
        Quest_Lion();
        Quest_Deer();
        Quest_Goat();
        Quest_Ele();
        Quest_Bear();
        Quest_Cro();
        Quest_Sheep();
        Quest_Rhin();
        Quest_Boar();
        Quest_Rabbit();
        Quest_Zebra();
    }
    public void Quest_Hip()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารฮิปโป";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารฮิปโป";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }

        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารฮิปโป";
            ScoreText.color = Color.red;
        }
    }
    public void Quest_Lion()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารสิงโต";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารสิงโต";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารสิงโต";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Deer()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารกวาง";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารกวาง";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารกวาง";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Goat()
    {
        ScoreText.text = score + "/1 ให้อาหารแพะ";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารแพะ";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารแพะ";
            ScoreText.color = Color.red;
        }
    }
    public void Quest_Ele()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารช้าง";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารช้าง";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }

        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารช้าง";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Bear()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารหมี";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารหมี";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารหมี";
            ScoreText.color = Color.red;
        }
    }
    public void Quest_Cro()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารจระเข้";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารจระเข้";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารจระเข้";
            ScoreText.color = Color.red;
        }
    }

     public void Quest_Sheep()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารแกะ";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารแกะ";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารแกะ";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Rhin()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารแรด";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารแรด";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }

        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารแรด";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Boar()
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

    public void Quest_Rabbit()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารกระต่าย";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารกระต่าย";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารกระต่าย";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Zebra()
    {
        ScoreText.text = score.ToString() + "/1 ให้อาหารม้าลาย";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ให้อาหารม้าลาย";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ให้อาหารแพะ";
            ScoreText.color = Color.red;
        }
    }
    IEnumerator WaitTextQuest()
    {
        yield return new WaitForSeconds(5);
        UIObject_textMessage.SetActive(false);
        UIObject_GetQuest.SetActive(false);
    }
}
