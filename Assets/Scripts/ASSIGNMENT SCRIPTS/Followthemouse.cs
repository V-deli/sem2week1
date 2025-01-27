using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followthemouse : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition); //the bee is being altered in the world screen, the mousePosition is being affected/used
        float screenlimitbelow = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height / 2, 0)).y; //making a float varible set equal to the top half of the screen height in world view

        if (mouse.y < screenlimitbelow) //if statment saying that if the y mouse position is less than the top half of the screen then it can preform the transformation of following the mouse position
        {
            mouse.y = screenlimitbelow; //screen height/2... mouse y is in the top half of the height of the screen
        }

        transform.position = mouse; //this line of code activates the bee to follow the position of the mouse
    }
}
//Using for the bee in Assignment One