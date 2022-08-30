using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatrotation : MonoBehaviour
{
    // Start is called before the first frame update
    float boatangle = 270;
    public GameObject boat;
    public float isrotating;
    bool easerotate;
    void Start()
    {
        easerotate = false; 
    }

    // Update is called once per frame
    void Update()
    {
       if (isrotating == 0)
        {
            easerotate = false;
        }
        gameObject.transform.rotation = Quaternion.Euler(0f, boatangle, 0f);
        isrotating = 0;
        if (Input.GetMouseButton(0))
        {
            easerotate=true;
            if (easerotate == true)
            {
                float startrotate = 0.1f;
               boatangle += startrotate;
                if (startrotate < 0.3f)
                {
                    startrotate += 0.01f;
                }
            }
            
            isrotating = 1;
        }
        if (Input.GetMouseButton(1))
        {
            easerotate = true;
            if (easerotate == true)
            {
                float startrotate = 0.1f;
                boatangle -= startrotate;
                if (startrotate < 0.3f)
                {
                    startrotate += 0.01f;
                }
            }
            isrotating = -1;
        }

        
        
    }
}
