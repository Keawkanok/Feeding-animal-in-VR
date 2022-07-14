using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Sc_Lion : MonoBehaviour
{

    public static float healtAmount;

    public static float Y = 180;
    void Start()
    {
        healtAmount = 0;
    }

    void Update()
    {
        TakeEatLikeFood();
    }

    void TakeEatLikeFood()
    {
        if (healtAmount >= 100)
        {
            if (Lion_Turret.target.gameObject)
            {
                Random_Food_Lion.speed = 1;
                Lion_Turret.target.transform.Translate(0, -15 * Time.deltaTime, 0);
            }
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
        }
    }
}
