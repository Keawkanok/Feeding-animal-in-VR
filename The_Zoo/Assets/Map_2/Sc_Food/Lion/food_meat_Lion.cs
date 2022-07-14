using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_meat_Lion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lion")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
