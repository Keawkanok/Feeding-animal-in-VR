using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{
    public Text TimerText;
    public static float timeValue = 301; // 301
    public static bool finnished = false;

    void Update()
    {
        if (finnished)
        {
            return;
        }

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            TimerText.color = Color.green;
            if (timeValue < 60)
            {
                // Timers < 60 minutes
                TimerText.color = Color.red;
                /*timeValue = Time.deltaTime;*/
            } 
        }
        else
        {
            timeValue = 0;
            TimerText.color = Color.red;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        // Text Show Timer 
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
