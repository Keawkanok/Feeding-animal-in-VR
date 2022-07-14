using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFoodBoar : MonoBehaviour
{

    Vector3 localScale;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = Food_Sc_Boar.healtAmount;
        transform.localScale = localScale;

    }
}
