using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar_Deer : MonoBehaviour
{
    Vector3 localScale;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = Deer_Script.healtAmount;
        transform.localScale = localScale;
    }
}
