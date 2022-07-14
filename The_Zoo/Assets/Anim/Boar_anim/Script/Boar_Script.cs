using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boar_Script : MonoBehaviour
{
    public Transform food;
    public Transform venom;
    private Animator anim;

    public static float healtAmount;
    void Start()
    {
        healtAmount = 0;
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        EatFood();
    }

    void EatFood()
    {
        if (Vector3.Distance(Boar_Turret.target.transform.position, transform.position) < 5)
        {
            Vector3 direction = Boar_Turret.target.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isIdle", false);
        if (other.tag == "likefood")
        {
            if (Boar_Script.healtAmount != 100)
            {
                ScoreBoar.instance_Boar.AddScore();
                healtAmount += 10f;
                anim.SetBool("isEating", true);
                StartCoroutine("WaitAnimation");
                if (healtAmount == 100){
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
