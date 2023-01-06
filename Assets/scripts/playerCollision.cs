using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public playerMovement movement;
 
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            // movement.enabled = false;
            FindObjectOfType<gameManager>().gameHasEnded = true;
            FindObjectOfType<gameManager>().endGame();
        }
    }

}
