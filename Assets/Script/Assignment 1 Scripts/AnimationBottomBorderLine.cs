using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBottomBorderLine : MonoBehaviour
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

        // If the left mouse button is pressed, grow the object's height
        if (Input.GetMouseButton(0))
        {
            // Only update time if it has not exceeded the max value
            if (time <= 1)
            {
                time += 0.0005f; // Slowly increase time

                // Evaluate the animation curve and apply to the Y-axis scale
                float newYScale = curve.Evaluate(time);

                // Update the object's scale, modifying only the Y-axis
                transform.localScale = new Vector3(transform.localScale.x, newYScale, 0);
            }
        }

        else
        {
            // If the mouse button is released, shrink the object 
            if (time > 0)
            {
                time -= 0.002f; // Gradually decrease time
            }
            else
            {
                time = 0; // Ensure time does not go below 0


            }

            // Evaluate the curve and apply to Y scale
            float newYScale = curve.Evaluate(time);

            // Update the object's scale, c.hanging only the Y-axis
            transform.localScale = new Vector3(transform.localScale.x, newYScale, 0);
        }










        }
    }

