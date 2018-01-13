using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public Movement movement;
    
    // Use this for initialization
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            
            // movement is same thing as GetComponent<PlayerMovement>()
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
