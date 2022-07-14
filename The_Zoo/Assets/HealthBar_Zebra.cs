using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar_Zebra : MonoBehaviour
{
    Vector3 localScale;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = Zebra_Script.healtAmount;
        transform.localScale = localScale;
    }
}
