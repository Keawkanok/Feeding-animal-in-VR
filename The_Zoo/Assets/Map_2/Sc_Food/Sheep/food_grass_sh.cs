using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_grass_sh : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sheep")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
