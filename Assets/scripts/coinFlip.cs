using UnityEngine;

public class coinFlip : MonoBehaviour
{
    public Transform coin;

    Vector3 rot = new Vector3(0, 0, 1);
    
    void Update()
    {
        // rotate the coin on the y axis
        coin.Rotate(rot);
    }
}
