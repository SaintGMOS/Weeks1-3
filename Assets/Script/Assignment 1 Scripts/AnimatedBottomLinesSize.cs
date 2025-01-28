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

        if (time <= 1)
        {
            time += 0.002f; // Increment time slowly

            // Evaluate the curve and apply to Y scale
            float newXScale = curve.Evaluate(time);
            
            transform.localScale = new Vector3(newXScale, transform.localScale.y,0);
        }
    }
}
