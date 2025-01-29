using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnimatedBottomLinesSize : MonoBehaviour
{

    public AnimationCurve curve;
    [Range(0, 1)]
    public float time;
    private bool isPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            isPressed = true;
        if (time <= 1)
        {
            time += 0.002f; // Increment time slowly

                // Evaluate the curve and apply to X scale
                float newXScale = curve.Evaluate(time);

                transform.localScale = new Vector3(newXScale, transform.localScale.y, 0);
            }

        }
        else
        {
            if (time > 0)
            {
                time -= 0.002f;
            }
            else 
            {
                time = 0;

            }

            float newXScale = curve.Evaluate(time);
            transform.localScale = new Vector3(newXScale, transform.localScale.y, transform.localScale.z);
            
            transform.localScale = new Vector3(newXScale, transform.localScale.y,0);
        }



    }
}
