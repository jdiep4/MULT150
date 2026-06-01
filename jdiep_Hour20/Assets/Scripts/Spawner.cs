using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creates the objects in the scene
public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;       // Reference to power-up game object
    public GameObject obstaclePrefab;      // Reference to obstacle game object
    public float spawnCycle = .5f;

    GameManager manager;
    float elapsedTime;
    bool spawnPowerup = true;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;        // Elapsed time is incremented 

        // Checks to see if it is time to spawn a new object
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;

            // If time to spawn a new object, script checks to see which object it should spawn
            if(spawnPowerup)
            {
                temp = Instantiate(powerupPrefab) as GameObject;       // Spawns a power-up
            }
            else
            {
                temp = Instantiate(obstaclePrefab) as GameObject;      // Or spawns an obstacle
            }

            // Created object is then moved left to right (randomly)
            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;

            // Gives reference to the game manager
            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;

            elapsedTime = 0;         // Decreases the elapsed time
            spawnPowerup = !spawnPowerup;        // Flips power-up flags so that opposite object will spawn next time
        }
    }
}
