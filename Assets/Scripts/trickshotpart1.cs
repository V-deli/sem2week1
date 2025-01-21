using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class trickshotpart1 : MonoBehaviour
{
    public float speed = 3f; //made speed variable to alter the time of speed when moving
    public AnimationCurve curve;
    [Range(0, 1)] public float t; //curve
    

    void Start()
{
        t = 0; 
}

    void Update()
    {
        Vector3 cirPos = transform.position;
        cirPos.x += speed; //transforming movemement of x speed
        cirPos.z = 0;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(cirPos);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1; // times neg 1 bounces back reverses, if statement to repeat
        }
        transform.position = cirPos;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            t += Time.deltaTime;
            if (t > 1)
            {
                t = 0;
            }
         cirPos.y = curve.Evaluate(t);
            Vector3 rot = transform.eulerAngles;
            rot.z = curve.Evaluate(t);
            transform.eulerAngles = rot;
        }

        transform.position = cirPos;
        }
    }

