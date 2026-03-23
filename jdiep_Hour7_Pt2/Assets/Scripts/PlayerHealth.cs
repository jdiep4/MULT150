using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;        // float health is assigned to "1004"
        float poisonDamage = 125.5f;       // float poisonDamage is assigned to 125.5
        Debug.Log(health);              // initial health is logged to the console (result: 1004)

        while (health > 0)        // while health is greater than 0;
        {
            health -= poisonDamage;     // poisonDamage is subtracted from the health until health reaches 0
            Debug.Log(health);
        }

        if(health <= 0)        // if health is less than or equal to zero than the log statement is executed
        {
            Debug.Log("Player has been unalived!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
