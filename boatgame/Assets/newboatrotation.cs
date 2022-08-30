using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newboatrotation : MonoBehaviour
{
    bool rotatespeed;
    bool fardshid;
    float rotatingspeed;
    bool checkforboth;
    void Start()
    {
        rotatespeed = false;
        fardshid = false;
        checkforboth = false;
    }

    // Update is called once per frame
    void Update()
    {

        //gameObject.transform.rotation = Quaternion.Euler(0f, //boatangle, 0f);

        if ((Input.GetMouseButton(1) == true))
        {
            if (Input.GetMouseButton(0) == true)
            {
                Debug.Log("sheeeeeeeeeeeeeeeeeeeeeeeee");
                rotatespeed = false;
                fardshid = false;
                rotatingspeed = 0.1f;
                //isrotating = 0;
            }



        }

        if (checkforboth == false)
        {


            if (Input.GetMouseButton(0))
            {
                rotatespeed = true;
                if (rotatespeed == true)
                {

                    fardshid = true;
                    if (fardshid == true)
                    {
                        //boatangle += rotatingspeed;
                        if (rotatingspeed < 100000f)
                        {
                            Debug.Log(rotatingspeed);
                            rotatingspeed += 1;
                        }
                    }

                }

                //isrotating = 1;
            }
            if (Input.GetMouseButton(1))
            {
                rotatespeed = true;
                if (rotatespeed == true)
                {

                    fardshid = true;
                    if (fardshid == true)
                    {
                        //boatangle -= rotatingspeed;
                        if (rotatingspeed > -100000f)
                        {
                            Debug.Log(rotatingspeed);
                            rotatingspeed -= 1;
                            //she
                        }
                    }

                }



                //isrotating = -1;
            }

        }
    }
}
