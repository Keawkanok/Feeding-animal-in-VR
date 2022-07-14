using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_meat_Hip : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hippopotamus")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
