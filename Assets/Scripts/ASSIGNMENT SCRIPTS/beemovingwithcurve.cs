using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beemovingwithcurve : MonoBehaviour
{
    
    public float speedofcurve = 3f; //public variable that will be used for the speed of movement
    public AnimationCurve curve; //public class to controll in the inepector 
    private float time; // creating a variable to evaluate animation curve
    private bool useCurve = false; //boolean that checks if the curve is activated with the specified key
    private Vector3 beeposition; // vector of bee position for lerp
    public float lerpSpeed = 5f; //speed variable for lerp
    //private float moveDirection = 1f;
    //private float halfScreen;


    void Start()
    {
       time = 0; //setting the inital starting time to zero 
        // halfScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
        beeposition = transform.position; // initialize bee to current position
    }


    void Update()
    {
        Vector3 beePos = transform.position; //creating a vector that transforms its position of the bee object

        if (Input.GetKey(KeyCode.LeftShift)) //if statement to see if the left shift has been pressed
        { 
        useCurve = true; //if the key has been pressed, then the curve is being used
        }
        else
        {
            useCurve= false; //otherwise the curve is not being used
        }

        beePos.x += speedofcurve * Time.deltaTime; // x moves horizontally, by the set speed, and stable pacing

        Vector2 screenpos = Camera.main.WorldToScreenPoint(beePos); // this chunk of code is making the bee bounce off the edges
        if (screenpos.x < 0 ||  screenpos.x > Screen.width) //setting the parameters of the screen to bounce in
        {
            speedofcurve = -speedofcurve; //once it moves to one direction, it turns back to the opposite direction and repeats
        }

        if (useCurve) //applies the animation curve to the object if it is activated with the shift key
        {
            time += Time.deltaTime; // setting it to be smooth with deltatime, increased the amount thats passed since its last frame
            if (time > 1f) //if exceeds valuee then...
            {
                time = 0f; //...resets to 0
            }
            float curveValue = curve.Evaluate(time); //to ge thte y value from the curve
            beeposition = new Vector3(beePos.x, curveValue, beePos.z); //set the bees position using the curve
            //beePos.y = curve.Evaluate(time); //udpates the y position of the bee, using the curve
            //Vector3 rot = transform.eulerAngles;
            //rot.z = curve.Evaluate(time);
            //transform.eulerAngles = rot;
        }
        else
        {
            time = 0f; //resets the curve if the curve is not activated
                       // beePos.y = 0f; // so the bees position can stay at the intended/default y position
            beeposition = new Vector3(beePos.x, 0f, beePos.z); //setting xyz values for vector, but defalt y
        }

        //transform.position = beePos; //this updates the position
        transform.position = Vector3.Lerp(transform.position, beeposition, lerpSpeed* Time.deltaTime); //lerp and delta time to smoothly transition the bees position
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

   
