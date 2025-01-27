using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beebouncingscreen : MonoBehaviour
{
    public float bounceSpeed = 5f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += bounceSpeed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            bounceSpeed = bounceSpeed * -1;
        }
        transform.position = pos;
    }
}
