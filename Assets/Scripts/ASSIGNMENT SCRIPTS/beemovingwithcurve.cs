using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beemovingwithcurve : MonoBehaviour
{
    public AnimationCurve curve;
    public float speedofcurve = 1f;
    private float time;
    private float moveDirection = 1f;
    private float halfScreen;

    void Start()
    {
        halfScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
    }


    void Update()
    {
        time += Time.deltaTime * speedofcurve * moveDirection;
        float xPos = curve.Evaluate(time);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

        if (transform.position.x > halfScreen || transform.position.x < -halfScreen)
        {
            moveDirection *= -1f;
            time = 0f;
        }
    } }

   
