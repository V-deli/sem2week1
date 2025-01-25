using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class rotateflowerscript : MonoBehaviour
{
    public float speadbudd = 30;
    private bool flowerrotating = true;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flowerrotating = false;
        }
        if (flowerrotating)
        {
            transform.Rotate(0, 0, speadbudd * Time.deltaTime);
        }
    }
}
