using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Sc_Deer : MonoBehaviour
{
    public static float healtAmount;

    public void Start()
    {
        healtAmount = 1;
    }

    public void Update()
    {
        TakeEatLikeFood();
    }

    void TakeEatLikeFood()
    {
        if (healtAmount >= 100)
        {
            if (Deer_Turret.target.gameObject)
            {
                Random_Food_Deer.speed = 1;
                Deer_Turret.target.transform.Translate(0, -15* Time.deltaTime, 0);
            }
        }
        if (Deer_Turret.target.transform.position.y < -15)
        {
            healtAmount = 0;
            Random_Food_Deer.speed = 1;
            Destroy(Deer_Turret.target.gameObject);
        }
       else if (Deer_Turret.target.transform.position.z > 10)
        {
            healtAmount = 0;
            Random_Food_Deer.speed = 1;
            Destroy(Deer_Turret.target.gameObject);
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Deer"))
        {
            healtAmount = 100f;
            Debug.Log("like food Deer");
        }
    }
}
