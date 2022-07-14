using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elephant_Sc : MonoBehaviour
{
    public float Addtime = 120;
    public float Minustime = -120;
    public static float Totaltime;
    public static Animator anim;

    public void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    public void Update()
    {
        AddTime();
    }
    public void AddTime()
    {
        if (ShowQuest_Ele.score == 1)
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
        if (ShowQuest_Ele.score == -1)
        {
            time.timeValue -= -Minustime;
            ShowQuest_Ele.score = 0;
            if (time.timeValue > Totaltime)
            {
                Minustime = 0;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isIdle", false);
        if (other.tag == "likefood")
        {
            if (ShowQuest_Ele.score == 0)
            {
                ShowQuest_Ele.score += 1;
            }
            anim.SetBool("isEating", true);
            StartCoroutine("WaitTextQuest");
        }

        if (other.tag == "notlikefood")
        {
            ShowQuest_Ele.score -= 1;
            anim.SetBool("isEating", true);
            StartCoroutine("WaitTextQuest");
        }
    }

    public IEnumerator WaitTextQuest()
    {
        yield return new WaitForSeconds(6);
        anim.SetBool("isIdle", true);
        anim.SetBool("isEating", false);
    }
}
