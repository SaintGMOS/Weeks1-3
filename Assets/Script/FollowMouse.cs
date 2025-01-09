using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

  

    // Start is called before the first frame update
    void Start()
    {
     


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Follow Mouse
        transform.position = mousePos;




    }
}
