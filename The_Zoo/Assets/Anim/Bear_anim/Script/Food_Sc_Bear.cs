using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Sc_Bear : MonoBehaviour
{
    Vector3 checkpoint;

    public static float healtAmount;
    public GameObject Effect;

    void Start()
    {
        healtAmount = 0;
        checkpoint = new Vector3((float)0.52, (float)0.5765495, (float)-1.42);
    }

    void Update()
    {
        TakeEat();
    }

    void TakeEat()
    {
        if (healtAmount >= 100)
        {
            if (Bear_Turret.target.gameObject)
            {
                Random_food.speed = 1;
                Bear_Turret.target.transform.Translate(0, -15 * Time.deltaTime, 0);

                /*GameObject effectIns = (GameObject)Instantiate(Effect, Turret.target.transform.position, Turret.target.transform.rotation);
                Destroy(effectIns, 2f);*/
            }
        }
        if (Bear_Turret.target.transform.position.y < -15)
        {
            healtAmount = 0;
            /*transform.position = checkpoint;*/
            Random_food.speed = 1;
            Destroy(Bear_Turret.target.gameObject);
   

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Bear"))
        {
            healtAmount = 100f;
            Debug.Log("like food");
        }
    }
}
