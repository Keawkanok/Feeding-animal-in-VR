using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_meat : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crocodile")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
