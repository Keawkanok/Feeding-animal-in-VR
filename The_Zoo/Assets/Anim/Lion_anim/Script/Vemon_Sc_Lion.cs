using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Vemon_Sc_Lion : MonoBehaviour
{
    public static float healtAmount;
    public static float GameOver = 0;
    void Start()
    {
        healtAmount = 0;
    }

    void Update()
    {
        TakeEat();
    }

    void TakeEat()
    {
        if (healtAmount >= 100)
        {
            if (Lion_Turret.target.gameObject)
            {
                Lion_Turret.target.transform.Translate(0, -15 * Time.deltaTime, 0);
                Random_Food_Lion.speed = 1;
            }
        }
        if (Lion_Turret.target.transform.position.y >= 4)
        {
            Random_Food_Lion.speed = 1;
            Destroy(Lion_Turret.target.gameObject);
        }
        if (Lion_Turret.target.transform.position.y < -15)
        {
            healtAmount = 0;
            Random_Food_Lion.speed = 1;
            Destroy(Lion_Turret.target.gameObject);
        } 
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lion")
        {
            healtAmount = 100f;
            if (Lion_Script.healtAmount != 0)
            {
                Lion_Script.healtAmount -= 10;
                ScoreLion.instance_Lion.NegativeScore();
                GameOver += 1;
            }
        }
    }
}
