using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform Player;

    private void LateUpdate()
    {
        Vector3 newPosititon = Player.position;
        newPosititon.y = transform.position.y;
        transform.position = newPosititon;

        transform.rotation = Quaternion.Euler(90f, Player.eulerAngles.y, 0f);
    }
  
}
