using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* 
           starts num at 22
           for loop keeps running until it reaches 100;
           num is added with 2 each time and then assigned to num   
        */
        for (int num = 22; num <= 100; num += 2)    
        {
            Debug.Log(num);     // outputs even numbers starting from 22 until it reaches 100
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
