using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vemon_Sc_Zebra : MonoBehaviour
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
            if (Zebra_Turret.target.gameObject)
            {
                Zebra_Turret.target.transform.Translate(0, -15 * Time.deltaTime, 0);
                Random_Food_Zebra.speed = 1;
            }
        }
        if (Zebra_Turret.target.transform.position.y < -15)
        {
            healtAmount = 0;
            Random_Food_Zebra.speed = 1;
            Destroy(Zebra_Turret.target.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zebra")
        {
            healtAmount = 100f;
            if (Zebra_Script.healtAmount != 0)
            {
                Zebra_Script.healtAmount -= 10;
                ScoreZebra.instance_Zebra.NegativeScore();
                GameOver += 1;
            }
        }
    }
}
