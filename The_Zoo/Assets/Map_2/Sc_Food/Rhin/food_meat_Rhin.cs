using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_meat_Rhin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rhinoceros")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
