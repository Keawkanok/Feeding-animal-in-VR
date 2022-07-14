using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meat_ch02 : MonoBehaviour
{
    // Start is called before the first frame update
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
            Debug.Log("Meat_ch02");
            Destroy(this.gameObject, 3f);
        }
    }
}
