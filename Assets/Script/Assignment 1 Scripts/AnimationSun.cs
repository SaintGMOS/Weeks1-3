using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnimationSun : MonoBehaviour
{

    public AnimationCurve curve; // Easing curve to control scaling
    [Range(0, 1)]
    public float time; // Animation progress
    public float speed; // Rotation speed
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
        if (time <= 1)
        {
            time += .0005f; // Increment time for smooth scaling

              // Apply scaling using the animation curve
              transform.localScale = Vector2.one * curve.Evaluate(time);

        }
            // Rotate the object continuously
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }

        else
        {
            // If the mouse button is not pressed, shrink the object back to its original size
            if (time > 0)
            {
                time -= 0.005f; // Decrease time for smooth shrinking

            }
            else
            {
                time = 0; // Time at 0 to prevent negative scaling


            }
            // Apply reverse scaling using the animation curve
            transform.localScale = Vector2.one * curve.Evaluate(time);

            // Continue rotating the object
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }





    }

}

