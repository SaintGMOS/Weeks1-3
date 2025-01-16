using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{


    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime; // Time.deltaTime Changes it MPS/UnitsPS

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        transform.Rotate(0, 0, speed * Time.deltaTime);

        if (screenPos.y < Screen.height)
        { 
            
        
        
        
        
        }


        
       









    }
}
