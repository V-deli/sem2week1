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
        transform.position = mouse;
    }
}
//Using for the bee in Assignment One