using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movewithkeys : MonoBehaviour
{
    public float move;
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
            transform.position += new Vector3(speed * move * Time.deltaTime, 0, 0);
    }
}
