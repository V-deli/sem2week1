using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounceoffscreen : MonoBehaviour
{
    public float speed = 0.1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos;
    }
}
