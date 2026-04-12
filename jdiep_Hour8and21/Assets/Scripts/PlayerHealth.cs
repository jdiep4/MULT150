using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;

    // Start is called before the first frame update
    void Start()
    {
        // Uses a potion

        // calls the UsePotion function with the current health
        healthpoints = UsePotion(healthpoints);      // healthpoints is updated when the function is called
        
        // returns the value of the updated healthpoints
        Debug.Log(healthpoints);                      // 3992 + 400 = 4392

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);                      // 4392 + 400 = 4792

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);                      // 4792 + 400 = 5192

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);                      // 5192 + 400 = 5592
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int health)    // function = UsePotion; return type = int; parameter = health
    {
        //health += 400;
        return health += 400;       // adds 400 to health & returns the result
    }
}
