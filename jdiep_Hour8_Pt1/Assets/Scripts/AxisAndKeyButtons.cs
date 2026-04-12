using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisAndKeyButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update loops continuously  --->  this is where we will put input detection
    void Update()
    {
        // NOTE: need to press on the arrow keys/W,A,S,D when running the scene

        // Getting Horizontal & Vertical Value from the respective axes & assigning them to variables

        // takes a string parameter with axis name that matches the one that is set in the Input Manager,
        //                                                                               and returns a float value
      
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if(horizontalValue != 0)      // if the horizontalValue is not equal to 0, then log it's value
        {
            Debug.Log("horizontal movement: " + horizontalValue);
        }

        if (verticalValue != 0)      // if the verticalValue is not equal to 0, then log it's value
        {
            Debug.Log("vertical movement: " + verticalValue);
        }
    

        // Getting Specific Key Inputs

        // takes KeyCode as parameter, and returns bool (true = if pressed, false = if not pressed)
        if(Input.GetKey(KeyCode.A))       // Continues logging its line of code as long as A is HELD down
        {
            Debug.Log("The A key is being pressed.");
        }

        if(Input.GetKeyDown(KeyCode.Z))     // Will only log the input when Z is FIRST pressed
        {
            Debug.Log("The Z key was pressed.");
        }

        // Getting Mouse Input

        // takes an integer for mouse button (0 = left, 1 = right, 2 = center),
        //                                             returns bool if button press is detected
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("pew pew!");
        }

        // to read mouse input
        float mouseXValue = Input.GetAxis("Mouse X");       // gets horizontal value of mouse movement
        float mouseYValue = Input.GetAxis("Mouse Y");       // gets the vertical value of mouse movement

        // 0 will indicate 0 movement, so we need to find the movement that is not equal to 0
        if(mouseXValue != 0)
        {
            Debug.Log("mouse X movement: ");
        }

        if(mouseYValue != 0)
        {
            Debug.Log("mouse Y movement: ");
        }
    }
}
