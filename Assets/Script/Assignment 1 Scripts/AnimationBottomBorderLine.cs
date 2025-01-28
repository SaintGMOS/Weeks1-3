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
        // Only update `time` if it's within range
        if (time <= 1)
        {
            time += 0.0005f; // Increment time slowly

            // Evaluate the curve and apply to Y scale
            float newYScale = curve.Evaluate(time);

            // Update the object's scale, changing only the Y-axis
            transform.localScale = new Vector3(transform.localScale.x, newYScale, 0);
        }
    }
}
