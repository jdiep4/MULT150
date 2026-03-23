// lists the libraries used (System.Collections & System.Collections.Generic often omitted unless it is used)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFunctions : MonoBehaviour
{
    // This is in the "class block" & will be available everywhere in this class

    /* 
       private = access modifier that is declared at class level
               = it is used only inside the file it is created
    */

    // public = access modifier that is visible to other scripts & the Unity editor
    public int runSpeed;       // creates a public variable that is is an integer (data/variable type called runSpeed


    // Start is called before the first frame update
    void Start()
    {
        // this is in a "local block" & will only be available in the Start method
        print("Start runs before an object Updates");
    }


    // Update is called once per frame
    void Update()
    {
        print("This is called once a frame");
    }
}
