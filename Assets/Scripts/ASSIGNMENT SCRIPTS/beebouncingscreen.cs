using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beebouncingscreen : MonoBehaviour
{
    public float bounceSpeed = 5f; //variable for the speed the beetravels across the screen horizontally, can be edited in the inspector
   // private float edgeSafe = 0.1f; //made this to ensure bee doesnt get stuck

    void Start()
    {

    }

    
    void Update()
    {
        Vector3 pos = transform.position; //new vector to transform the position of an object
        pos.x += bounceSpeed * Time.deltaTime; //altering the x position, added delta time for the bee to fly smoothly

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos); //the bee position is being edited in the screen point

        if (screenPos.x <= 0 || screenPos.x >= Screen.width) //2 restraints of the screen edges for the bee, if the 
        {
            //bounceSpeed = Mathf.Abs(bounceSpeed);
            bounceSpeed = bounceSpeed * -1; // if the 2 conditions are met then this line of code runs saying the bee moves at this speed and once it hits the edge it goes the opposite way due to it being multiplyed by a -1
        }

        transform.position = pos; //this reiterates that the position of the object is being altered
    }
}
