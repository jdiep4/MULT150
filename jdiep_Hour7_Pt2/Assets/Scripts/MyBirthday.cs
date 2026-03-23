using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // create a loop that outputs the days of your birthday month in number format
        // april only has 30 days
        for (int day = 1; day <= 30; day++)
        {
            // if it's the 28th (my birthday) then output the statement, if not then ouput the day
            if (day == 28)         
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
