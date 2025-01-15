using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class AnimationCurvdemoo : MonoBehaviour
{

    public AnimationCurve curve;

    [Range(0, 1)]
    public float t;

    void Start()
    {

    }


    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }


        transform.localScale = Vector3.one * curve.Evaluate(t);
    }
}
