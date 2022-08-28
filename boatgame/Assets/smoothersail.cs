using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class smoothersail : MonoBehaviour
{
    float angle;
    float isrotating;
    public GameObject rotationchecker;
    public GameObject windvector;
    public GameObject boat;
    public Quaternion sailpulled = Quaternion.Euler(0f, 15f, 0f);
    public Quaternion sailletted = Quaternion.Euler(0f, 90f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        isrotating = rotationchecker.GetComponent<boatrotation>().isrotating;
    }


    // Update is called once per frame
    void Update()
    {
        float scrollDir = Input.GetAxis("Mouse ScrollWheel");
        
        angle = boat.transform.rotation.eulerAngles.y - windvector.transform.rotation.eulerAngles.y;
        Debug.Log(gameObject.transform.localEulerAngles.y);
        bool bruh = true;
        if ((angle > 340) && (angle < 20))
        {
            Quaternion sailflip = Quaternion.identity;
            Quaternion sailstate = Quaternion.identity;
            if (bruh == true)
            {
               sailflip = Quaternion.Inverse(gameObject.transform.localRotation);
               sailstate = gameObject.transform.localRotation;
                bruh = false;
            }

           
            if (isrotating == -1)
            {
                 gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailflip, 0.2f);
            }
            if (isrotating == 1)
            {
                gameObject.transform.localRotation = Quaternion.RotateTowards(gameObject.transform.localRotation, sailstate, 0.2f);
            }

            sailletted = Quaternion.Euler(0f, 270f, 0f);

            sailpulled = Quaternion.Euler(0f, 345f, 0f);
        }

        
        if (scrollDir > 0)
        {
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, sailletted, 2000f * Time.deltaTime);
            //out

        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            //in
            transform.localRotation = Quaternion.Slerp(transform.localRotation, sailpulled, 30f * Time.deltaTime);
        }
    }

    
}
