using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class Trap : MonoBehaviour
    {
        public int damage = 10; // Amount of damage the trap deals

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // Check if the object entering the trap is the player
            TopDownCharacterController player = collision.GetComponent<TopDownCharacterController>();
            if (player != null)
            {
                // Apply damage to the player
                player.TakeDamage(damage);
            }
        }
    }
}
