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
       Vector3 beeposition = Camera.main.ScreenToWorldPoint( Input.mousePosition );
        beeposition.z = 0;
        Vector2 facing = beeposition - transform.position;

        transform.up = facing;
    }
}
