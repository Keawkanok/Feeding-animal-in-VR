using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vemon_Sc_Deer : MonoBehaviour
{
    public static float healtAmount;
    public static float GameOver = 0;

    void Start()
    {
        healtAmount = 0;
    }

    void Update()
    {
        TakeNotLikeEat();
    }

    void TakeNotLikeEat()
    {
        if (healtAmount >= 100)
        {
            if (Deer_Turret.target.gameObject)
            {
                Deer_Turret.target.transform.Translate(0, -15 * Time.deltaTime, 0);
                Random_Food_Deer.speed = 1;
            }
        }
        if (Deer_Turret.target.transform.position.y < -15)
        {
            healtAmount = 0;
            Random_Food_Deer.speed = 1;
            Destroy(Deer_Turret.target.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Deer")
        {
            healtAmount = 100f;
            if (Deer_Script.healtAmount != 0)
            {
                Deer_Script.healtAmount -= 10;
                ScoreDeer.instance_Deer.NegativeScore();
                GameOver += 1;
            }
        }
    }
}
