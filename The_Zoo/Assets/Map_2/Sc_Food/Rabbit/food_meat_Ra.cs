using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_meat_Ra : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rabbit")
        {
            /*Destroy(this.gameObject, 6f);*/
        }
    }
}
