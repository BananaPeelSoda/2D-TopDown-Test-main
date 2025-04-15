using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Cainos.PixelArtTopDown_Basic
{

    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;
        public int maxHealth = 100; // Maximum health of the player
        private int currentHealth; // Current health of the player

        private Animator animator;
        private bool isDead = false; // To prevent multiple death triggers

        public LayerMask groundLayer; // Layer the player must be on to survive
        [SerializeField] private GameObject destroyeffect, thunderFlashEffect, GameOverPanel, EnemyBody;

        private void Start()
        {
            animator = GetComponent<Animator>();
            currentHealth = maxHealth; // Initialize health
        }

        private void Update()
        {
            if (isDead) return; // Prevent movement if the player is dead

            // Check if the player is on the required layer
            if (!IsOnGround())
            {
                Die();
                return;
            }

            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }

            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().linearVelocity = speed * dir;
        }

        // Method to check if the player is on the ground layer
        private bool IsOnGround()
        {
            Vector2 position = transform.position;
            float radius = 0.1f;
            Debug.DrawLine(position, position + Vector2.down * radius, Color.red, 0.1f); // Visualize the check
            return Physics2D.OverlapCircle(position, radius, groundLayer) != null;
        }

        // Method to take damage
        public void TakeDamage(int damage)
        {
            if (isDead) return; // Ignore damage if already dead

            currentHealth -= damage;
            Debug.Log("Player took damage! Current Health: " + currentHealth);

            if (currentHealth <= 0)
            {
                Die();
                PlayerDied();
            }
        }
        private void PlayerDied()
        {
            LevelManager.instance.GameOver();
            gameObject.SetActive(false);
        }
        // Method to handle player death
        private void Die()
        {
            isDead = true;
            Debug.Log("Player has died!");
            animator.SetBool("IsMoving", false); // Stop movement animation
            animator.SetTrigger("Die"); // Trigger death animation (if available)
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero; // Stop movement

            // Example: Restart the level after a delay
        }
    }
}


