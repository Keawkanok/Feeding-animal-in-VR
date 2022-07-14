using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_fish_Big : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bear")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
