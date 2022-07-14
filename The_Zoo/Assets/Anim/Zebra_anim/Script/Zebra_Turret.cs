using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zebra_Turret : MonoBehaviour
{
    public static Transform target;

    [Header("Attributes")]

    public float range = 3.4f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    [Header("Unity Setup Fields")]

    public string foodsTag = "likefood";
    public string notlikefoodTag = "notlikefood";
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    public void UpdateTarget()
    {
        GameObject[] foods = GameObject.FindGameObjectsWithTag(foodsTag);
        float shortestDistance = Mathf.Infinity; // ระยะทางที่สั้นที่สุด

        GameObject nearestFood = null; // ใกล้ที่สุด

        foreach (GameObject food in foods)
        {
            float distanceToFood = Vector3.Distance(transform.position, food.transform.position);
            shortestDistance = distanceToFood;
            nearestFood = food;
        }

        if (nearestFood != null && shortestDistance <= range)
        {
            target = nearestFood.transform;
        }

        GameObject[] notlikefood = GameObject.FindGameObjectsWithTag(notlikefoodTag);
        foreach (GameObject notlike in notlikefood)
        {
            float distanceToFood = Vector3.Distance(transform.position, notlike.transform.position);
            shortestDistance = distanceToFood;
            nearestFood = notlike;
        }

        if (nearestFood != null && shortestDistance <= range)
        {
            target = nearestFood.transform;
        }
    }

    public void Update()
    {
        if (target == null)
            return;

        if (fireCountdown <= 0f)
        {
            
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
