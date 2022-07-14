using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest_Bear : MonoBehaviour
{
    public static Quest_Bear instance;

    public Text QuestBear01;

    float GetQuest01 = 0;
  

    private void Awake()
    {
        instance = this;

    }
    void Start()
    {
        QuestBear01.text = GetQuest01.ToString() + "/10" + " Like Food";
        QuestBear01.color = Color.red;

      

    }

    // Update is called once per frame
    void Update()
    {
        if (GetQuest01 == 10)
        {
            GetQuest01 = 10;
            QuestBear01.color = Color.green;
        }
    
    }

    public void Quest()
    {
        GetQuest01 += 1;
        QuestBear01.text = GetQuest01.ToString() + "/10" + " Like Food";
        
    }

    
}
