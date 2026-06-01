using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextureScroller ground;
    public float gameTime = 10;

    float totalTimeElapsed = 0;
    bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Keeps track of time
    void Update()
    {
        if(isGameOver)
        {
            return;
        }

        // Adds time since lastframe (Time.deltaTime) to totalTimeElapsed
        totalTimeElapsed += Time.deltaTime;      
        gameTime -= Time.deltaTime;

        if(gameTime <= 0)         // Checks whether the game is over (when remaining time = 0)
        {
            isGameOver = true;
        }
    }

    // Called whenever the player hits a power-up or an obstacle
    // AdjustTime() method adjusts the amount of time remaining
    public void AdjustTime(float amount)
    {
        gameTime += amount;

        if(amount < 0)      // If the amount is negative(an obstacle), SlowWorldDown() is called
        {
            SlowWorldDown();
        }
    }

    // SlowWorldDown() & SpeedWorldUp() methods work in conjunction with one another

    // Called whenever a player hits an obstacle, the time is slowed down
    void SlowWorldDown()
    {
        // Cancel any invokes to speed the world up
        // Then slow the world down for 1 second

        // Cancels any SpeedWorldUp() methods waiting to be called because player hit another obstacle
        CancelInvoke();     
        Time.timeScale = 0.5f;

        // Call the method written here in x seconds
        Invoke("SpeedWorldUp", 1);     // Method is the one in quotes & number is in seconds
    }

    // Speeds everything back up so that the game returns back to normal
    void SpeedWorldUp()
    {
        Time.timeScale = 1f;
    }

    // Note: this is using Unity's legacy GUI system
    /* 
       Draws the remaining time to the scene while the game is running & shows total time the game
       lasted after it ends
    */
    void OnGUI()
    {
        if(!isGameOver)
        {
            Rect boxRect = new Rect(Screen.width / 2 - 50, Screen.height - 100, 100, 50);
            GUI.Box(boxRect, "Time Remaining");

            Rect labelRect = new Rect(Screen.width / 2 - 10, Screen.height - 80, 20, 40);
            GUI.Label(labelRect, ((int)gameTime).ToString());
        }
        else
        {
            Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
            GUI.Box(boxRect, "Game Over");
            
            Rect labelRect = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 80, 90, 40);
            GUI.Label(labelRect, "Total Time:" + (int)totalTimeElapsed);

            Time.timeScale = 0;      // Everything slows down when player hits an obstacle
        }
    }
}
