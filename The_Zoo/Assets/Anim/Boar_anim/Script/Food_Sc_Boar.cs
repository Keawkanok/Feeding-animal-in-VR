using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Food_Sc_Boar : MonoBehaviour
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
            if (Boar_Turret.target.gameObject)
            {
                Random_food_Boar.speed = 1;
                Boar_Turret.target.transform.Translate(0, -15 * Time.deltaTime, 0);
                /*Destroy(Boar_Turret.target.gameObject);*/
                /*GameObject effectIns = (GameObject)Instantiate(Effect, Boar_Turret.target.transform.position, Boar_Turret.target.transform.rotation);
                Destroy(effectIns, 2f);*/
            }
        }
        if (Boar_Turret.target.transform.position.y < -15)
        {
            healtAmount = 0;
            Random_food_Boar.speed = 1;
            Destroy(Boar_Turret.target.gameObject);
            /*transform.position = checkpoint;*/
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Boar"))
        {
            healtAmount = 100f;
            Debug.Log("like food Boar");
        }
    }
}

