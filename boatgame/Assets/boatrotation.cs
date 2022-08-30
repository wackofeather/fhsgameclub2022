using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatrotation : MonoBehaviour
{
    // Start is called before the first frame update
    float boatangle = 270;
    public GameObject boat;
    public float isrotating;
    bool rotatespeed;
    
    void Start()
    {
        rotatespeed = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (isrotating == 0)
        {
            rotatespeed = false;
        }
        gameObject.transform.rotation = Quaternion.Euler(0f, boatangle, 0f);
        isrotating = 0;
        if (Input.GetMouseButton(0))
        {
            rotatespeed = true;
            if (rotatespeed == true)
            {
                float rotatingspeed = 0.1f;
                boatangle += rotatingspeed;
                if (rotatingspeed < 10000f)
                {
                    rotatingspeed += 1f * Time.deltaTime;
                }
            }
            
            isrotating = 1;
        }
        if (Input.GetMouseButton(1))
        {
            rotatespeed = true;
            if (rotatespeed == true)
            {
                float rotatingspeed = 0.1f;
                boatangle -= rotatingspeed;
                if (rotatingspeed > -10000f)
                {
                    rotatingspeed -= 1f * Time.deltaTime;
                }
            }

            
            
            isrotating = -1;
        }

        
        
    }
}
