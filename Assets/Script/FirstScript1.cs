using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript1 : MonoBehaviour
{
    public float speed = 0.05f;


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

        if (screenPos.x < 0 )
        {
            Vector3 fixedPos = new Vector3(0,0,0);
           pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }
        if (screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }
        transform.position = pos;

    }
}
