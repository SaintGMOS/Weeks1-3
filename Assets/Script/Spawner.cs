using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefab,mouse,Quaternion.identity);     // Spawns the shapes/triangles wherever your mouse clicks/pressed.
            // Instantiate(prefab, transform); Does the same thing except the new shapes become under the orginal/the parent shape or wtv 

        }

    }
}
