using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_code : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*float angle = Vector3.Angle(direction, this.transform.forward);*/
        /*    if (Vector3.Distance(food.transform.position, transform.position) < 10)
            {
                Vector3 direction = food.position - this.transform.position;
                direction.y = 0;

                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

                anim.SetBool("isIdle", false);
                if (direction.magnitude > 1)
                {
                    this.transform.Translate(0, 0, 0.003f);
                   *//* anim.SetBool("isWalking", true);
                    anim.SetBool("isEeting", false);*//*
                }

            }*/

        // Food
        /*   Vector3 direction = food.position - this.transform.position;
           float angle = Vector3.Angle(direction, this.transform.forward);
           if (Vector3.Distance(food.transform.position, transform.position) < 4.9 && angle < 30)
           {
               direction.y = 0;

               this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

               anim.SetBool("isIdle", false);
               if (direction.magnitude > 2)
               {
                   this.transform.Translate(0, 0, 0.003f);
                   anim.SetBool("isWalking", true);
                   anim.SetBool("isEating", false);

                   if (Food_Sc.healtAmount >= 100)
                   {
                       anim.SetBool("isIdle", true);
                       anim.SetBool("isWalking", false);
                       anim.SetBool("isEating", false);
                       Debug.Log("Stop");
                   }
               }
               else
               {
                   anim.SetBool("isEating", true);
                   anim.SetBool("isWalking", false);
                   if (Food_Sc.healtAmount >= 100)
                   {
                       anim.SetBool("isIdle", true);
                       anim.SetBool("isWalking", false);
                       anim.SetBool("isEating", false);
                       Debug.Log("Stop");
                   }
               }
           }
           else
           {
               anim.SetBool("isIdle", true);
               anim.SetBool("isWalking", false);
               anim.SetBool("isEating", false);

           }*/

        // Venom
        /*  Vector3 directions = venom.position - this.transform.position;
          float angles = Vector3.Angle(directions, this.transform.forward);
          if (Vector3.Distance(venom.transform.position, transform.position) < 4.9 && angles < 30)
          {
              directions.y = 0;

              this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(directions), 0.1f);

              anim.SetBool("isIdle", false);
              if (directions.magnitude > 2)
              {
                  this.transform.Translate(0, 0, 0.003f);
                  anim.SetBool("isWalking", true);
                  anim.SetBool("isEating", false);

                  if (Venom_Script.healtAmount >= 100)
                  {
                      anim.SetBool("isIdle", true);
                      anim.SetBool("isWalking", false);
                      anim.SetBool("isEating", false);
                      Debug.Log("Stop");
                  }
              }
              else
              {
                  anim.SetBool("isEating", true);
                  anim.SetBool("isWalking", false);
                  if (Venom_Script.healtAmount >= 100)
                  {
                      anim.SetBool("isIdle", true);
                      anim.SetBool("isWalking", false);
                      anim.SetBool("isEating", false);
                      Debug.Log("Stop");
                  }
              }
          }

          Vector3 direction = food.position - this.transform.position;
          float angless = Vector3.Angle(directions, this.transform.forward);
          if (Vector3.Distance(food.transform.position, transform.position) < 4.9 && angless < 30)
          {

              direction.y = 0;

              this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

              anim.SetBool("isIdle", false);
              if (direction.magnitude > 2)
              {
                  this.transform.Translate(0, 0, 0.003f);
                  anim.SetBool("isWalking", true);
                  anim.SetBool("isEeting", false);
                  if (Food_Sc.healtAmount >= 100)
                  {
                      anim.SetBool("isIdle", true);
                      anim.SetBool("isWalking", false);
                      anim.SetBool("isEating", false);
                      Debug.Log("Stop");
                  }
              }
              else
              {
                  anim.SetBool("isEating", true);
                  anim.SetBool("isWalking", false);
                  if (Food_Sc.healtAmount >= 100)
                  {
                      anim.SetBool("isIdle", true);
                      anim.SetBool("isWalking", false);
                      anim.SetBool("isEating", false);
                      Debug.Log("Stop");
                  }
              }
          }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
