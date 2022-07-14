using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Food_Lion : MonoBehaviour
{
    public static float speed = 1f;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = Waypoint_Lion.points[0];
    }

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
        if (wavepointIndex >= Waypoint_Lion.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = Waypoint_Lion.points[wavepointIndex];

    }
   
}
