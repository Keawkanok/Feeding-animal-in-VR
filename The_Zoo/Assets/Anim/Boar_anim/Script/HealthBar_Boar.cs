using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Boar : MonoBehaviour
{
    Vector3 localScale;

    public void Start()
    {
        localScale = transform.localScale;
    }

    public void Update()
    {
        localScale.x = Boar_Script.healtAmount;
        transform.localScale = localScale;
    }
}
