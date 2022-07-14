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
        ScoreText.text = score.ToString() + "/1 ���������Ի�";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ���������Ի�";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }

        if (score == 0)
        {
            ScoreText.text = score + "/1 ���������Ի�";
            ScoreText.color = Color.red;
        }
    }
    public void Quest_Lion()
    {
        ScoreText.text = score.ToString() + "/1 ���������ԧ�";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ���������ԧ�";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ���������ԧ�";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Deer()
    {
        ScoreText.text = score.ToString() + "/1 �������á�ҧ";

        if (score == 1)
        {
            ScoreText.text = score + "/1 �������á�ҧ";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 �������á�ҧ";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Goat()
    {
        ScoreText.text = score + "/1 ����������";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ����������";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ����������";
            ScoreText.color = Color.red;
        }
    }
    public void Quest_Ele()
    {
        ScoreText.text = score.ToString() + "/1 �������ê�ҧ";

        if (score == 1)
        {
            ScoreText.text = score + "/1 �������ê�ҧ";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }

        if (score == 0)
        {
            ScoreText.text = score + "/1 �������ê�ҧ";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Bear()
    {
        ScoreText.text = score.ToString() + "/1 �����������";

        if (score == 1)
        {
            ScoreText.text = score + "/1 �����������";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 �����������";
            ScoreText.color = Color.red;
        }
    }
    public void Quest_Cro()
    {
        ScoreText.text = score.ToString() + "/1 �������è����";

        if (score == 1)
        {
            ScoreText.text = score + "/1 �������è����";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 �������è����";
            ScoreText.color = Color.red;
        }
    }

     public void Quest_Sheep()
    {
        ScoreText.text = score.ToString() + "/1 ����������";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ����������";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ����������";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Rhin()
    {
        ScoreText.text = score.ToString() + "/1 ���������ô";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ���������ô";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }

        if (score == 0)
        {
            ScoreText.text = score + "/1 ���������ô";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Boar()
    {
        ScoreText.text = score.ToString() + "/1 ����������ٻ��";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ����������ٻ��";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            Debug.Log("score " + score);
            ScoreText.text = score + "/1 ����������ٻ��";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Rabbit()
    {
        ScoreText.text = score.ToString() + "/1 �������á�е���";

        if (score == 1)
        {
            ScoreText.text = score + "/1 �������á�е���";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 �������á�е���";
            ScoreText.color = Color.red;
        }
    }

    public void Quest_Zebra()
    {
        ScoreText.text = score.ToString() + "/1 ��������������";

        if (score == 1)
        {
            ScoreText.text = score + "/1 ��������������";
            ScoreText.color = Color.green;
            Destroy(this.UIObject_NotFood);
            UIObject_textMessage.SetActive(false);
        }
        if (score == 0)
        {
            ScoreText.text = score + "/1 ����������";
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
