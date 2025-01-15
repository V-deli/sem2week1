using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.1f;

    void Start()
    {

    }

    
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed;

        //        //test right
        //        Vector2 screensizeintheworld = new Vector2(Screen.width, Screen.height);
        //        Vector2 screensizeintheworld = new Vector2();
        //        screensizeintheworld.x = Camera.main.ScreenToWorldPoint(screenSize);

        //        //test left
        //        Vector2 screenzerointheworld = Camera.main.ScreenToWorldPoint(Vector2.zero);
        //        if (pos.x < screenzerointheworld || pos.x > screensizeintheworld.x)
        //                { 
        //        speed = speed * -1;
        //    }
        transform.position = pos;
    }
}
