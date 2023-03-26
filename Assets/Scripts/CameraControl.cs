using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousexValue = Input.GetAxis("Mouse X");
        float mouseyValue = Input.GetAxis("Mouse Y");

        if(mousexValue != 0)
        {
            print("Mouse X movement is " + mousexValue);
        }

        if(mouseyValue != 0)
        {
            print("Mouse Y movement is " + mouseyValue);
        }
    }
}
