using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class rotateflowerscript : MonoBehaviour
{
    public float speadbudd = 30; //variable to controll the speed of rotation public to edit in inspecotr
    private bool flowerrotating = true; //to track if the flower is rotating


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //using the space key.. if space key is down then...
        {
            flowerrotating = !flowerrotating; //checks if the space bar is pressed, if so, rotating true, if its rotating and clicked, the flower stops 
        }
        if (flowerrotating) // if true, rotate flower
        {
            transform.Rotate(0, 0, speadbudd * Time.deltaTime); //rotate around Z axiz using speed variable and delta time for even pace
        }
    }
}
