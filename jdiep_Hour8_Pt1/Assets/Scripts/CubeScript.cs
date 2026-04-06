using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // The object continuously moves along the positive x axis while being rotated along the z axis

        /* Reference to a component = name of variable storing reference followed by a dot
                                                                         followed by property being modified       
         */
        transform.Translate(.05f, 0f, 0f);     // Moves the object along the positive x axis
       
        transform.Rotate(0f, 0f, 1f);          // Rotates the object along the z axis
        
        // Scales the object to double its size in all directions
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);      
    }
}
