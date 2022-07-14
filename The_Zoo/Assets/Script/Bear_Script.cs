using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear_Script : MonoBehaviour
{
    public Transform food; // Food
    public Transform venom; // venom

    private Animator anim;

    public static float healtAmount;

    void Start()
    {
        healtAmount = 1;
        anim = GetComponentInChildren<Animator>();

    }

    void Update()
    {
       

        if (Vector3.Distance(food.transform.position, transform.position) < 5)
        {
            Vector3 direction = food.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false);
            if (direction.magnitude > 2.3)
            {
                this.transform.Translate(0, 0, 0.004f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isEating", false);

            }
            else
            {
                anim.SetBool("isEating", true);
                anim.SetBool("isWalking", false);
            }
        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isEating", false);
        }

        if (Vector3.Distance(venom.transform.position, transform.position) < 5)
        {
            Vector3 direction = venom.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false);
            if (direction.magnitude > 1.5)
            {
                this.transform.Translate(0, 0, 0.003f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isEating", false);

            }
            else
            {
                anim.SetBool("isEating", true);
                anim.SetBool("isWalking", false);
            }
        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isEating", false);
        }
        EatFood();


    }

    void EatFood()
    {
        if (Vector3.Distance(Bear_Turret.target.transform.position, transform.position) < 5)
        {
            Vector3 direction = Bear_Turret.target.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false);
            if (direction.magnitude > 1.5)
            {
                this.transform.Translate(0, 0, 0.009f);
                anim.SetBool("isWalking", true);
                Random_food.speed = 0;
                anim.SetBool("isEating", false);

            }
            else
            {
                anim.SetBool("isEating", true);
                anim.SetBool("isWalking", false);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
         if (other.tag == "likefood")
        {
            healtAmount += 10f;
            ScoreManger.instance.AddScore();
            Debug.Log("Foods Bear");
            DialogueBox.Instance.StartDialogue();


        }
        if (other.tag == "notlikefood")
        {
            Debug.Log("notlikefood Bear");
        }
        
    }

}
