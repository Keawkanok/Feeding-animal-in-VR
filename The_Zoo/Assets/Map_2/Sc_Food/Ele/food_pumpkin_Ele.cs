using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_pumpkin_Ele : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Elephant")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
