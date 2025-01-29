using System.Buffers.Text;
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

        // Object moves along the x-axis based on speed and time.
        // Time.deltaTime ensures frame rate independence.
        pos.x += speed * Time.deltaTime;

        // Convert the object's world position to screen coordinates.
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        // Check if the object has moved past the left screen boundary.
        if (screenPos.x < -140)
        {
            // Set a fixed position on the right side of the screen.
            Vector3 fixedPos = new Vector3(0, 0, 0);

            // Convert the fixed screen position back to world coordinates and set the object's position.
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;

            // Reverse direction of movement.
            speed = speed * -1;
        }

        // Check if the object has moved past the right screen boundary.
        if (screenPos.x > Screen.width + 140)
        {
            // Set a fixed position on the left side of the screen.
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);

            // Convert the fixed screen position back to world coordinates and set the object's position.
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;

            // Reverse direction of movement.
            speed = speed * -1;
        }

        // Apply the updated position to the object.
        transform.position = pos;

    }


}


