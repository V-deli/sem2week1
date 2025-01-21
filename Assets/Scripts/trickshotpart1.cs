using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class trickshotpart1 : MonoBehaviour
{
     public float speed = 3f; //made speed variable to alter the time of speed when moving


void Start()
{

}

void Update()
{
    Vector3 cirPos = transform.position;
    cirPos.x += speed; //transforming movemement of x speed

    Vector2 screenPos = Camera.main.WorldToScreenPoint(cirPos); 

    if (screenPos.x < 0 || screenPos.x > Screen.width)
    {
        speed = speed * -1; // times neg 1 bounces back reverses, if statement to repeat
    }
    transform.position = cirPos;
}
  
}
