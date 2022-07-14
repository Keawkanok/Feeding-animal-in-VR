using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_grapes : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Deer")
        {
            Destroy(this.gameObject, 6f);

        }
    }
}
