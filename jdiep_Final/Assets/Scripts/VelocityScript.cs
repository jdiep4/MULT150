using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    public float startSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        // Moves the ball all around the arena
        Rigidbody rigidBody = GetComponent <Rigidbody>();
        rigidBody.velocity = new Vector3 (startSpeed, 0, startSpeed);
    }

}
