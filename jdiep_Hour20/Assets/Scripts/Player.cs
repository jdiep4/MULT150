using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Manages the player movement & collision controls & manages the phase effect
public class Player : MonoBehaviour
{
    // Attributes = Special tags that modify code
    // This code uses Header attribute --> causes Inspector view to display header's string

    // These variables hold references to the game manager & 2 materials
    // When player phases out, the materials are swapped
    [Header("References")]            
    public GameManager manager;
    public Material normalMat;
    public Material phasedMat;

    // These variables handle gameplay preferences (level bounds & player's sideways speed)
    [Header("Gameplay")]
    public float bounds = 3f;
    public float strafeSpeed = 4f;
    public float phasedCooldown = 2f;

    Renderer mesh;
    Collider collision;
    bool canPhase = true;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
        collision = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the player based on input
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;

        Vector3 position = transform.position;
        position.x += xMove;

        // Checks to make sure the player isn't out of bounds this means that it keeps the player in the gauntlet
        position.x = Mathf.Clamp(position.x, -bounds, bounds);         
        transform.position = position;

        /* 
         * Checks whether the player is currently pressing the spacesbar ("Jump")
         * If the user is pressing the spacebar, the player phases out & prepares to phase back in after a 
           defined cooldown
         * Player phased out = disabled collider so player cannot hit obstacles or collect power-ups
        */
        if(Input.GetButtonDown("Jump") && canPhase)
        {
            canPhase = false;
            mesh.material = phasedMat;
            collision.enabled = false;

            Invoke("PhasedIn", phasedCooldown);
        }
    }

    void PhaseIn()
    {
        canPhase = true;
        mesh.material = normalMat;
        collision.enabled = true;
    }
}
