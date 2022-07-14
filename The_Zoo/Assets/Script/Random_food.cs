using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_food : MonoBehaviour
{
    public static float speed = 1f;

    private Transform target;
    private int wavepointIndex = 0;

   /* float speedStop = 0f;*/

  /*  void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        print(this.gameObject);
        speed = speedStop;
        Debug.Log("Stop");
        Rigidbody rbdy = gameObject.GetComponent<Rigidbody>();

        //Stop Moving/Translating
        rbdy.velocity = Vector3.zero;

        //Stop rotating
        rbdy.angularVelocity = Vector3.zero;
    }*/
    void Start()
    {
        target = Waypoint.points[0];
    }


    // Update is called once per frame
    void Update()
    {
      

    Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoints();
        }
 
    }

    void GetNextWaypoints()
    {
        if (wavepointIndex >= Waypoint.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = Waypoint.points[wavepointIndex];
       
    }

   
}
