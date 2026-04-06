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
        Debug.Log(health);              // variable health is logged to the console (result: 1004)
        
        health -= poisonDamage;      // can also be written as: health=health-poisonDamage
        Debug.Log(health);         // 878.5

        health -= poisonDamage;
        Debug.Log(health);         // 753

        health -= poisonDamage;
        Debug.Log(health);         // 627.5

        health -= poisonDamage;
        Debug.Log(health);         // 502

        health -= poisonDamage;
        Debug.Log(health);         // 376.5

        health -= poisonDamage;
        Debug.Log(health);         // 251

        health -= poisonDamage;
        Debug.Log(health);         // 125.5

        health -= poisonDamage;
        Debug.Log(health);         // 0

        Debug.Log("Player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
