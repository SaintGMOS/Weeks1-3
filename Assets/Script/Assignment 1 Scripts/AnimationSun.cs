using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnimationSun : MonoBehaviour
{

    public AnimationCurve curve;
    [Range(0, 1)]
    public float time;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
        if (time <= 1)
        {
            time += .0005f;


            transform.localScale = Vector2.one * curve.Evaluate(time);

        }
     transform.Rotate(0, 0, speed * Time.deltaTime);
        }

        else
        {
            if (time > 0)
            {
                time -= 0.005f;
                
    }
            else
            {
                time = 0;
                

            }
            transform.localScale = Vector2.one * curve.Evaluate(time);
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }





    }

}

