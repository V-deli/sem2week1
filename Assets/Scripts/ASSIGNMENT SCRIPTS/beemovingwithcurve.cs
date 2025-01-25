using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beemovingwithcurve : MonoBehaviour
{
    
    public float speedofcurve = 3f;
    public AnimationCurve curve;
    private float time;
    private bool useCurve = false;
    //private float moveDirection = 1f;
    //private float halfScreen;


    void Start()
    {
       time = 0;
        // halfScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
    }


    void Update()
    {
        Vector3 beePos = transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        { 
        useCurve = true;
        }
        else
        {
            useCurve= false;
        }

        beePos.x += speedofcurve * Time.deltaTime;

        Vector2 screenpos = Camera.main.WorldToScreenPoint(beePos);
        if (screenpos.x < 0 ||  screenpos.x > Screen.width)
        {
            speedofcurve = -speedofcurve;
        }

        if (useCurve)
        {
            time += Time.deltaTime;
            if (time > 1f)
            {
                time = 0f;
            }
            beePos.y = curve.Evaluate(time);
            //Vector3 rot = transform.eulerAngles;
            //rot.z = curve.Evaluate(time);
            //transform.eulerAngles = rot;
        }
        else
        {
            time = 0f;
            beePos.y = 0f;
        }
        transform.position = beePos;
        }
        //time += Time.deltaTime * speedofcurve * moveDirection;
        //float xPos = curve.Evaluate(time);
        //transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

        //if (transform.position.x > halfScreen || transform.position.x < -halfScreen)
        //{
        //    moveDirection *= -1f;
        //    time = 0f;
        //}
    }

   
