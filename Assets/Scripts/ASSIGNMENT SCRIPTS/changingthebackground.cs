using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changingthebackground : MonoBehaviour
{
    public Camera cam; // variable allows script to modify the camera
    public Color background; // temporaly defines what the backgreound colour is set to
    //I change the colour in inspector by dropping it in an empty game object

    //Couldn't change the background colour in main camera?

    void Start()
    {
        if (cam == null) //if statment to check if the camera var. isnt assigned in the inspector
        {
            cam = Camera.main; //assigns the main camera to the variable
        }
      
    }


    void Update()
    {
        //an old idea I wanted to try out of curiousity
        //if (Input.GetKeyDown(KeyCode.LeftShift)) //check if the key was pressed down in that frame
        //{
        //    cam.backgroundColor = background; //changes colour of camera to whats stored in variable
        //}
        cam.backgroundColor = background; //changes colour of camera to whats stored in variable
        }
}
    

