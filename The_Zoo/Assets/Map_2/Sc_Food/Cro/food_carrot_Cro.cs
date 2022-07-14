using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_carrot_Cro : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crocodile")
        {
            /*Destroy(this.gameObject, 6f);*/
        }
    }
}
