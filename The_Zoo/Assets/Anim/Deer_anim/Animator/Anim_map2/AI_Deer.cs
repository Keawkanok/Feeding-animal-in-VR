using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Deer : MonoBehaviour
{
    private NavMeshAgent agent;

    public float radius;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (!agent.hasPath)
        {
            agent.SetDestination(GetPoint_Deer.Instance_Deer.GetRandomPoint());
          /*  agent.SetDestination(GetPoint_Deer.Instance_Deer.GetRandomPoint(transform, radius));*/

        }
    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

#endif
}
