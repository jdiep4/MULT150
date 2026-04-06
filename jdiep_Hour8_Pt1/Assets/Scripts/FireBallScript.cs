using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    int TakeDamageFromFireball()        // Method called TakeDamageFromFireball
    {
        int playerHealth = 100;       // playerHealth is assigned to 100
        return playerHealth - 5;      // returns playerHealth when 5 is deducted from it; result is 95
    }

    // Method called TakeDamageFromFireball has an int parameter called damage
    int TakeDamageFromFireball(int damage)      
    {
        int playerHealth = 100;       // playerHealth is assigned to 100
        return playerHealth - damage;      // returns playerHealth - damage
    }

    // Method called TakeDamageFromFireball has two int parameters called damage and playerHealth
    int TakeDamageFromFireball(int damage, int playerHealth)      
    {
        return playerHealth - damage;      // returns playerHealth - damage
    }

    // Start is called before the first frame update
    void Start()
    {
        // variable x that calls the method TakeDamageFromFireball
        int x = TakeDamageFromFireball();    
        print("Player health: " + x);        // prints out the value of the player's current health (x)

        // variable y that calls the method TakeDamageFromFireball that has 25 as it's parameter
        int y = TakeDamageFromFireball(25);    
        print("Player health: " + y);          // prints out the value of the player's current health (y)

        // variable z that calls the method TakeDamageFromFireball that has 30 and 50 as it's parameters
        int z = TakeDamageFromFireball(30, 50);
        print("Player health: " + z);          // prints out the value of the player's current health (z)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
