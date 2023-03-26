using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if(horizontalValue != 0)
        {
            print("Horizontal movement selected: " + horizontalValue);
        }

        if(verticalValue != 0)
        {
            print("Vertical movement selected: " + verticalValue);
        }

        if(Input.GetKey(KeyCode.M))
        {
            print("The M key is pressed down");
        }

        if(Input.GetKey(KeyCode.O))
        {
            print("The O key is pressed down");
        }

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
