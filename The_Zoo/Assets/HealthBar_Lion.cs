using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar_Lion : MonoBehaviour
{
    Vector3 localScale;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        localScale.x = Lion_Script.healtAmount;
        transform.localScale = localScale;
    }
}
