using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleMovement : MonoBehaviour
{
    public float speed = 0.05f; // Movement speed of the object.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the object.
        Vector3 pos = transform.position;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < -140)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }
        if (screenPos.x > Screen.width + 140)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }
        transform.position = pos;

    }


}


