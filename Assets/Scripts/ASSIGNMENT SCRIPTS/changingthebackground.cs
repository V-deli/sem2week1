using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changingthebackground : MonoBehaviour
{
    public Camera cam; // variable allows script to modify the camera
    public Color background; // temporaly defines what the backgreound colour is set to
    //I change the colour in inspector by dropping it in an empty game object

    void Start()
    {
        if (cam == null) //if statment to check if the camera var. isnt assigned in the inspector
        {
            cam = Camera.main; //assigns the main camera to the variable
        }
      
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) //check if the key was pressed down in that frame
        {
            cam.backgroundColor = background; //changes colour of camera to whats stored in variable
        }
    }
}
    

