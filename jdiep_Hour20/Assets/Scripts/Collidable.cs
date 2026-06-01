using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Power-ups & obstacles need to move toward the player & modify game time when player collides with them
public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float moveSpeed = 20f;
    public float timeAmount = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Object is moved each time Update() is called
    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime); 
    }

    // When object collides with something, it checks to see if it collided with the player
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            manager.AdjustTime(timeAmount);
            Destroy(gameObject);      // If it collides with player, it lets Game Manager know & then destroy itself
        }
    }
}
