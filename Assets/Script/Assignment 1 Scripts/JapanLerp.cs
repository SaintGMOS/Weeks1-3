using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class JapanLerp : MonoBehaviour
{

    public AnimationCurve curve;  // Easing curve
    public Transform startPoint;  // Starting position
    public Transform endPoint;    // Target position
    public float time;      // Animation progress (0 to 1)
    private bool isRunning = false; // Track animation state


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // If the left mouse button is pressed, start moving forward
        if (Input.GetMouseButton(0)) 
        {
            time += .0005f; // Increment time to progress animation
            isRunning = true;  // Enable animation
        }

        if (isRunning)
        {

            // If animation progress reaches 1, stop further increments
            if (time >= 1f)  // Stop animation when finished
            {
                time = 1f; // Clamp time to 1 (fully transitioned)
                isRunning = false; // Stop animation
            }

            // Use the animation curve to adjust interpolation
            float adj = curve.Evaluate(time);

            // Smoothly Lerp from startPoint to endPoint based on adjusted time
            transform.position = Vector3.Lerp(startPoint.position, endPoint.position, adj); // Lerp with curve
        }
        else
        {
            // When not running, smoothly move back towards the start position
            if (time > 0)
            {
                time -= 0.002f; //  Decrease time for reverse animation
            }
            else
            {
                time = 0;  // Ensure time does not go below 0
            }
            // Apply easing curve for a smooth transition back
            float adj = curve.Evaluate(time);
            // Smoothly move back from endPoint to startPoint
            transform.position = Vector3.Lerp(startPoint.position, endPoint.position, adj); // Lerp with curve

        }
    }
}
