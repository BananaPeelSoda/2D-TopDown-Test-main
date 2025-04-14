using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Perform trap action, such as moving the trap object
        }
    }
}
