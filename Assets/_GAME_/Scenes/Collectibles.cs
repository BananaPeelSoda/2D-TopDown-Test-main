using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Increment player score or inventory
            PlayerManager.Instance.IncrementScore(1);

            // Destroy the collectible
            Destroy(gameObject);
        }
    }
}