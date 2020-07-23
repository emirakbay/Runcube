using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;
      


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "ColorChanger")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
