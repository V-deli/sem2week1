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
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float screenlimitbelow = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height / 2, 0)).y;

        if (mouse.y < screenlimitbelow)
        {
            mouse.y = screenlimitbelow;
        }

        transform.position = mouse;
    }
}
//Using for the bee in Assignment One