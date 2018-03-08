using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisoionInfo)
    {
        if (collisoionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
            
        }
        
    }
}
