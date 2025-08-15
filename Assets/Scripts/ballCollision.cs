using UnityEngine;

public class ballCollision : MonoBehaviour
{   
    [SerializeField] playerMovement playerMovementScript;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "collidable")
        {
            Debug.Log("Collided with " + collision.gameObject.tag);
            playerMovementScript.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if(collision.gameObject.tag == "Finish")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
