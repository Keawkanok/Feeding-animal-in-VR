using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_apple_Ze : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zebra")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
