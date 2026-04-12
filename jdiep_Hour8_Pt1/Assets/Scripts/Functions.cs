using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string sentence1 = "W in the chat";
        string sentence2 = "L in the chat";
        LogSomething(sentence1);
        LogSomething(sentence2);

        LogSomething("I'm a hard coded string");

        LogSomething("W coding!", 100);


        double health = 100;       // assign health to 100
        health = TakeDamage(health, 20);    // health is 100 and damage is 20
        Debug.Log(health);         // health is 80

        health = TakeDamage(health, 20);    // health is 80 and damage is 20
        Debug.Log(health);        // health is 60

        health = TakeDamage(health, 30, 0.5);     // subtract 30 multiplied by 0.5 from health (60)
        Debug.Log(health);       // returns the result back into health (45)
    }

    /*    void LogSomething()
        {
            Debug.Log("W in the chat");

            // This function has a void type => returns nothing back to us
            // There is nothing in the parenthesis, so we are passing no data to the function
        }
    */


    //	** both of these LogSomething methods have 2 different signatures
    //        -- this allows us to overload the function to reuse the name for a different code block

    void LogSomething(string something)
    {
        for (int i = 1; i <= 3; i++)

        {
            // loop that runs three times
            Debug.Log(something);
        }
    }

    void LogSomething(string something, int numLoops)
    {
        for (int i = 1; i <= numLoops; i++)

        {
            // loop that runs any number of times times
            Debug.Log(something);
        }
    }

    double TakeDamage(double health, double damage)
    {
        // by assigning the return value back into health,
        //                  the player's health is updated each time the player takes damage
        return health - damage;      // health is 100-20 and health is now 80; do it again and health is 60
    }

    double TakeDamage(double health, double damage, double damageModifier)
    {
        // can be used for when there is an armor or buff that might reduce damage that is received
        return health - (damage * damageModifier);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
