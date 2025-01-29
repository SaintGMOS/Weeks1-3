using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnimationClouds : MonoBehaviour
{

    public AnimationCurve curve;
    [Range(0, 1)]
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the left mouse button is pressed, grow the object
        if (Input.GetMouseButton(0))
        {
            // Update time
        if (time <= 1)
        {
            time += .0005f; // Slowly increase time

             // Apply scaling using the animation curve
            transform.localScale = Vector2.one * curve.Evaluate(time);

        }
        }

        else
        {
            // If the mouse button is released, shrink the object smoothly
            if (time > 0)
            {
                time -= 0.005f; // Gradually decrease time
            }
            else
            {
                time = 0; // Ensure time does not go below 0

            }
            // Apply reverse scaling using the animation curve
            transform.localScale = Vector2.one * curve.Evaluate(time);
        }
    }
}
