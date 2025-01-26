using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerfollowsbee : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
       Vector3 beeposition = Camera.main.ScreenToWorldPoint( Input.mousePosition ); // the mouse position converts from screen position to world.
        beeposition.z = 0; // setting z pos to 0 since its 2d not needed
        Vector2 facing = beeposition - transform.position; //calculates the direction vector from flower to bee/mouse

        transform.up = facing; //moves the flower to face the direction of bee, by setting the vector to that position
    }
}
