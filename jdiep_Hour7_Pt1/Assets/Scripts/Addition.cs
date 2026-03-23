using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 2;     /* int variable a that is assigned to 2
                          can also do--> int a;   a=2;    */
        int b = 4;     // int b assigned to 4
        int c = 8;     // int c assigned to 8
        int sum = a + b + c;     // result of a+b+c is assigned to int sum

        sum++;      // increment operator that increases the value of sum by 1
        
        // can use Debug.Log() or print() = both output to console
        Debug.Log(sum);      // logs the value of sum to the console
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
