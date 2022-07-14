using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_meat_G : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goat")
        {
            /*Destroy(this.gameObject, 6f);*/
        }
    }
}
