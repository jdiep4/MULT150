using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentScript : MonoBehaviour
{
    // holds a reference to our camera
    // declared outside of Start(), so that other functions can access it
    Camera cameraComponent;    // declare a variable of type camera and naming it cameraComponent

    // Start is called before the first frame update

    // put it in Start() when we want the action to be performed once
    void Start()
    {
        // using GetComponent<>() function to get Camera component specifically & assigning it to variable we made 
        cameraComponent = GetComponent<Camera>();

        // makes the game zoomed out
        cameraComponent.fieldOfView = 100f;   // take cameraComponent & use dot operator to access fieldOfView property
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
