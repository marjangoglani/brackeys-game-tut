using UnityEngine;

public class playerCollectibles : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            Debug.Log("coin!");
            other.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
