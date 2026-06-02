using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;

        if(collidedWith.tag == gameObject.tag)    // Checks tag of each object that contacts it against its own tag
        {
            // if its true, the object is destroyed, the goal is flagged as solved & its light is disabled
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
        }
    }
}
