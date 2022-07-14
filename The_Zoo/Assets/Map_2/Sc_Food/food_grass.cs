using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_leek : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goat")
        {
            Debug.Log("Food_grass");
            Destroy(this.gameObject, 3f);
        }
    }
}
