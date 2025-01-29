using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnimatedBottomLinesSize : MonoBehaviour
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

        // If the left mouse button is pressed, increase the object's width
        if (Input.GetMouseButton(0))
        {
         // Update time
        if (time <= 1)
        {
            time += 0.002f; // Increment time slowly

                // Evaluate the curve and apply to X scale
                float newXScale = curve.Evaluate(time);

                // Update the object's scale, modifying only the X-axis
                transform.localScale = new Vector3(newXScale, transform.localScale.y, 0);
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

            // Evaluate the curve and apply to X-axis scale
            float newXScale = curve.Evaluate(time);
            // Update the object's scale, modifying only the X-axis
            transform.localScale = new Vector3(newXScale, transform.localScale.y,0);
        }



    }
}
