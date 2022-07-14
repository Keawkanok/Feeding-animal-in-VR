using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zebra")
        {
            Destroy(this.gameObject);
        }
    }
}
