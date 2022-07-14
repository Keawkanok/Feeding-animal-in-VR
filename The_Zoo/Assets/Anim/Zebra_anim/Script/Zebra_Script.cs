using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zebra_Script : MonoBehaviour
{
    public Transform food; // Food
    public Transform venom; // venom
    private Animator anim;
    public static float healtAmount;

    public void Start()
    {
        healtAmount = 0;
        anim = GetComponentInChildren<Animator>();
    }

    public void Update()
    {
        EatFood();
    }

    public void EatFood()
    {
        if (Vector3.Distance(Zebra_Turret.target.transform.position, transform.position) < 5)
        {
            Vector3 direction = Zebra_Turret.target.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isIdle", false);
        if (other.tag == "likefood")
        {
            if (Zebra_Script.healtAmount != 100)
            {
                ScoreZebra.instance_Zebra.AddScore();
                healtAmount += 10f;
                anim.SetBool("isEating", true);
                StartCoroutine("WaitAnimation");
                if (healtAmount == 100)
                {
                    healtAmount += 0f;
                }
            }
        }
    }
   public IEnumerator WaitAnimation()
    {
        yield return new WaitForSeconds(0);
        anim.SetBool("isIdle", true);
        anim.SetBool("isEating", false);
    }
}
