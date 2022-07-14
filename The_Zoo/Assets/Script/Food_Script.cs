using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    public static float healtAmount;
    void Start()
    {
        healtAmount = 1;
    }

    void Update()
    {
        if (healtAmount >= 100)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Bear"))
        {
            healtAmount += 50f;

        }
    }
}
