using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Checks each goal every frame & determines when all four goals are solved

    public GoalScript blue, green, red, orange, chaos;
    private bool isGameOver = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;
    }

    void OnGUI()
    {
        /*
           Every frame, the manager checks to see if all the goals are solved. If they are, the managers sets the
           variable isGameOver to true & displays "game over" message on the screen
        */
        if(isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
        }
    }
}
