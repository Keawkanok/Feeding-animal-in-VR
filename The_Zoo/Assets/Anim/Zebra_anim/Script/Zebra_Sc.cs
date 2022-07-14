using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zebra_Sc : MonoBehaviour
{
    public float Addtime = 120;
    public float Minustime = -120;
    public static float Totaltime;
    public static Animator anim;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        AddTime();
    }

    public void AddTime()
    {
        if (ShowQuest_Zebra.score == 1)
        {
            /* Totaltime = time.timeValue + Addtime;
             time.timeValue = Totaltime;*/
            time.timeValue += Addtime;
            /*Debug.Log(time.timeValue);*/
            if (Totaltime < time.timeValue)
            {
                Addtime = 0;
                /*ShowQuest_Goat.score = 0;*/
                /*Debug.Log(Totaltime);*/
            }
        }
        if (ShowQuest_Zebra.score == -1)
        {
            time.timeValue -= -Minustime;
            /*Debug.Log(time.timeValue);*/
            ShowQuest_Zebra.score = 0;
            if (time.timeValue > Totaltime)
            {
                Minustime = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isIdle", false);
        if (other.tag == "likefood")
        {
            if (ShowQuest_Zebra.score == 0)
            {
                ShowQuest_Zebra.score += 1;
            }
            anim.SetBool("isEating", true);
            StartCoroutine("WaitTextQuest");
        }

        if (other.tag == "notlikefood")
        {
            ShowQuest_Zebra.score -= 1;
            anim.SetBool("isEating", true);
            StartCoroutine("WaitTextQuest");
        }
    }

    IEnumerator WaitTextQuest()
    {
        yield return new WaitForSeconds(6);
        anim.SetBool("isIdle", true);
        anim.SetBool("isEating", false);
    }
}
