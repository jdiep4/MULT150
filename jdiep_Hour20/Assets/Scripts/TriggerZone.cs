using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Destroys any objects that make their way past the player
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);     // Destroys any obect that enters it
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
