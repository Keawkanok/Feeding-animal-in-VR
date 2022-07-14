using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vemon_Sc_Boar : MonoBehaviour
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
            if (Boar_Turret.target.gameObject)
            {
                Boar_Turret.target.transform.Translate(0, -15 * Time.deltaTime, 0);
                Random_food_Boar.speed = 1;
                Destroy(Boar_Turret.target.gameObject);
            }
        }
        if (Boar_Turret.target.transform.position.y < -15)
        {
            healtAmount = 0;
            Random_food_Boar.speed = 1;
            Destroy(Boar_Turret.target.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boar")
        {
            healtAmount = 100f;
            if (Boar_Script.healtAmount != 0)
            {
                Boar_Script.healtAmount -= 10;
                ScoreBoar.instance_Boar.NegativeScore();
                GameOver += 1;
            }
        }
    }
}
