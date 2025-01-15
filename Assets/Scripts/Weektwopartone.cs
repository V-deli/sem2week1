using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weektwopartone : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Start()
    {

    }


    void Update()
    {
        //        Vector2 = Camera.main.ScreenToWorldPoint();
        //        Vector2 direction = 
        //        transform.forward =direction;
        transform.Rotate(0, 0, - rotationSpeed * Time.deltaTime);

        //I dont understand why there is a red underline under my variable name: rotspeed
        //I wrote it on the line above the class lol- dont do that 
        //Also clicked on capital transform instead of lower case.
    }
}
    
