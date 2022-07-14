using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_corn_Deer : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Deer")
        {
            Destroy(this.gameObject, 6f);
        }
    }
}
