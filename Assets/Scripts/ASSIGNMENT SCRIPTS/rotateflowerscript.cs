using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateflowerscript : MonoBehaviour
{
    public float speadbudd = 30; 
    


    void Start()
    {
        
    }

    
    void Update()
    {
        //Vector3 rotateflower = transform.eulerAngles;
        //rotateflower.z += 1;
        //transform.eulerAngles = rotateflower;

        transform.Rotate(0, 0, speadbudd* Time.deltaTime);
    }
}
