using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_turnip : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boar")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
