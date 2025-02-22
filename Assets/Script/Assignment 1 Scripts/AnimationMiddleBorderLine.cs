using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnimationMiddleBorderLine : MonoBehaviour
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
        // If the left mouse button is pressed, grow the object's width
        if (Input.GetMouseButton(0))
        {
        // Only update time if it's within range
        if (time <= 1)
        {
            time += 0.0005f; // Increment time slowly

            // Evaluate the curve and apply to Y scale
            float newXScale = curve.Evaluate(time);

            // Update the object's scale, changing only the Y-axis
            transform.localScale = new Vector3(newXScale, transform.localScale.y, 0);
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
                time = 0;
            }
            // Evaluate the curve and apply to the X-axis scale
            float newXScale = curve.Evaluate(time);

            // Update the object's scale, modifying only the X-axis
            transform.localScale = new Vector3(newXScale, transform.localScale.y, transform.localScale.z);

        }





    }
}
