using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Sc_Zebra : MonoBehaviour
{
    public static float healtAmount;
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
            if (Zebra_Turret.target.gameObject)
            {
                Random_Food_Zebra.speed = 1;
                Zebra_Turret.target.transform.Translate(0, -15 * Time.deltaTime, 0);
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
        }
    }
}
