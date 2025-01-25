using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changingthebackground : MonoBehaviour
{
    public Camera cam;
    public Color background = Color.blue;


    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
        cam.backgroundColor = background;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            cam.backgroundColor = background;
        }
    }
}
    

