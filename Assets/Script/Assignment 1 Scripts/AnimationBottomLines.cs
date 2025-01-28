using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBottomLines : MonoBehaviour
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
            time += .0005f;

            
            transform.localScale = Vector2.one * curve.Evaluate(time);
          
        }

        


    }




}

