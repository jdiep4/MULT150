using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start() includes components at runtime that you want to interact with
    void Start()
    {
        
    }

    // These lines of code are in Update() because it continuously reads the input
    void Update()
    {
        /* Gets the user's input (what key the user is pressing) for the GetAxis method 
         * this means that the GetAxis() reads the name of the axis as a string & returns the value of that axis
        */
        float hVal = Input.GetAxis("Horizontal");    // GetAxis method of Input object
        float vVal = Input.GetAxis("Vertical");
        
        if(hVal != 0)
        {
            print("Horizontal movement selected: " + hVal);
        }

        if(vVal != 0)
        {
            print("Vertical movement selected: " + vVal);
        }

        // Gets the user's input if the 'M' key is continuously pressed down
        if(Input.GetKey(KeyCode.M))
        {
            print("The 'M' key is pressed down");    // 'M' key outputs the entire time
        }

        // Gets the user's input if the 'O' key is pressed
        if(Input.GetKeyDown(KeyCode.O))
        {
            print("The 'O' key was pressed");        // 'O' key outputs only when first pressed
        }

        // Get's the user's input for which direction the mouse is being moved
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        if(mxVal != 0)
        {
            print("Mouse X movement selected: " + mxVal);
        }

        if(myVal != 0)
        {
            print("Mouse Y movement selected: " + myVal);
        }

    }
}
