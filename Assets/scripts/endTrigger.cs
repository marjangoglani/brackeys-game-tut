using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public gameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            gameManager.completeLevel();

        }
    }
}
